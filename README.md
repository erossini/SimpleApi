# SimpleApi
Given a new green field project, the requirements are that are two different payloads, A and B that need to be exposed to our customers via the internet. An audit log is also required for every request that is received. Given this has to be done quickly and cheaply to prove some value. How would you go about designing this system?

The solution is split in 4 different implementation:
- Logic App Classic (`LogicAppClassic`)
- Logic App (New version 2021) (`azuks-mcp-vaq-log-d1`)
- Azure Function (`SimpleAzureFunction`)
- WebApi
  - Domain (`SimpleApi.Domain`)†
  - Persistence (`SimpleApi.Persistence` and `SimpleApi.Persistence.Interface`)
  - Api (`SimpleApi` and `SimpleApi.App`)

† Domain is a .NET Standard project to be used in the WebApi project and in the Azure Function

![Solution in Visual Studio](https://user-images.githubusercontent.com/9497415/127474718-4898c1ba-15ff-42d1-90e8-a324b5f7b83f.png)

## Architecture and security
The nature of the project and the deploy environment impact on the architecture. In the projects you have different approaches. **Logic Apps** are build in **Azure** and the basic security is to use a key in the URL. However, it is possible to put in front of them an **Azure API Manager** that provides a security layer and integration with **Azure Active Directory** and **OpenId** (such as **IdentityServer4**).

The Domain project has only the model across the solution and, for this reason, is build with **.NET Standard**. This project is used as dependencies in the Azure Function and the API.

### WebApi
The project is divided into the following layers:
- Domain
- Infrastructure
- Persistence
- Specs/Tests

### Architecture for Logic Apps
<img width="756" alt="LogicApps" src="https://user-images.githubusercontent.com/9497415/127405581-a9fe4a05-4944-4ced-9b11-617792488e30.png">

### Basic architecture
<img width="424" alt="Basic" src="https://user-images.githubusercontent.com/9497415/127405786-cf42bf72-bd32-44eb-8b4c-72bb82327471.png">

## Screenshot

### Azure Function
![Azure Function output](https://user-images.githubusercontent.com/9497415/127470592-c529c9db-4c78-416f-8f6a-3e35875a8722.png)

### Swagger for the WebApi
![image](https://user-images.githubusercontent.com/9497415/127469874-cd7a1090-d79d-45a5-8aec-c742f00fa385.png)

### Logic App Classic
![LogicApp Classic Screenshot from Azure portal](https://user-images.githubusercontent.com/9497415/127470090-f2bceae5-e038-4724-8e32-4c514a074218.png)

### Logic App in Visual Studio
![LogicApp in VisualStudio 2019](https://user-images.githubusercontent.com/9497415/127470322-d24fe22b-83a1-4425-bc39-b757b3a5d286.png)
