using System;

namespace SimpleApi.App
{
    /// <summary>
    /// Class ApiSettings.
    /// </summary>
    public class ApiSettings
    {
        /// <summary>
        /// Gets or sets the authority.
        /// </summary>
        /// <value>The authority.</value>
        public string Authority { get; set; }
        /// <summary>
        /// Gets or sets the name of the API.
        /// </summary>
        /// <value>The name of the API.</value>
        public string ApiName { get; set; }
        /// <summary>
        /// Gets or sets the API secret.
        /// </summary>
        /// <value>The API secret.</value>
        public string ApiSecret { get; set; }
    }
}
