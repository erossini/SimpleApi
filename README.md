# VaqSimpleApi
Given a new green field project, the requirements are that are two different payloads, A and B that need to be exposed to our customers via the internet. An audit log is also required for every request that is received. Given this has to be done quickly and cheaply to prove some value. How would you go about designing this system?

The solution is split in 3 different implementation:
- Logic App Classic
- Logic App (New version 2021)
- Azure Function
- WebApi
  - Domain †
  - Persistence
  - Api

† Domain is a .NET Standard project to be used in the WebApi project and in the Azure Function

![image](https://user-images.githubusercontent.com/9497415/127468919-6802c9d3-a6f9-4061-bf14-182b91a332c3.png)

## Architecture for Logic Apps
<img width="756" alt="LogicApps" src="https://user-images.githubusercontent.com/9497415/127405581-a9fe4a05-4944-4ced-9b11-617792488e30.png">

## Basic architecture
<img width="424" alt="Basic" src="https://user-images.githubusercontent.com/9497415/127405786-cf42bf72-bd32-44eb-8b4c-72bb82327471.png">
