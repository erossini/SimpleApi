using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimpleApi.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleApi.Controllers
{
	[Authorize]
	[ApiController]
	[ApiVersion("1.0")]
	[Route("api/v{version:apiVersion}/[controller]")]
	public class BaseController<T> : ControllerBase where T : class
	{
        /// <summary>
        /// The log
        /// </summary>
        protected ILogger<BaseController<T>> _log;

        private readonly IHttpContextAccessor _httpContextAccessor;

        /// <summary>
        /// The providers
        /// </summary>
        protected IAsyncRepository<T> _db;

        public BaseController(IAsyncRepository<T> repository,
            IHttpContextAccessor httpContextAccessor,
            ILogger<BaseController<T>> log)
        {
            _log = log;
            _db = repository;
            _httpContextAccessor = httpContextAccessor;
        }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>IActionResult.</returns>
        [HttpGet]
        [Route("GetValue")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetValue(long id)
        {
            _log.LogDebug("Request GetValue");

            var rtn = await _db.GetByIdAsync(id);
            return rtn != null ? Ok(rtn) : NotFound();
        }

        /// <summary>
        /// Gets the values.
        /// </summary>
        /// <returns>The list of Azure Categories</returns>
        /// <response code="200">Retrieved the list of Azure Category</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetValues()
        {
            _log.LogDebug("Request GetValues");

            return Ok(_db.ListAllAsync());
        }

        /// <summary>
        /// Patches the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>IActionResult.</returns>
        [HttpPatch]
        public async Task<IActionResult> Patch(T value)
        {
            _log.LogDebug("Request Patch");

            if (value == null)
                return BadRequest();

            await _db.UpdateAsync(value);
            return Ok();
        }

        /// <summary>
        /// Posts the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>IActionResult.</returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(long))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Post(T value)
        {
            _log.LogDebug("Request Post");

            var userName = _httpContextAccessor.HttpContext.User.Identity.Name;

            if (value == null)
                return BadRequest();

            return Ok(await _db.AddAsync(value));
        }

        #region Delete

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>IActionResult.</returns>
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Delete(long id)
        {
            _log.LogDebug("Request Delete");

            await _db.DeleteAsync(id);
            return Ok();
        }

        #endregion Delete
    }
}