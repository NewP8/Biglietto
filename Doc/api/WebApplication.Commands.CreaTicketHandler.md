# <a id="WebApplication_Commands_CreaTicketHandler"></a> Class CreaTicketHandler

Namespace: [WebApplication.Commands](WebApplication.Commands.md)  
Assembly: Web.dll  

Comando di creazione nuovo ticket

```csharp
public class CreaTicketHandler : IRequestHandler<CreaTicket, int>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CreaTicketHandler](WebApplication.Commands.CreaTicketHandler.md)

#### Implements

IRequestHandler<CreaTicket, int\>

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="WebApplication_Commands_CreaTicketHandler__ctor_MediatR_IMediator_Biglietto_Domain_Aggregates_ITicketRepository_Microsoft_Extensions_Logging_ILogger_WebApplication_Commands_CreaTicketHandler__"></a> CreaTicketHandler\(IMediator, ITicketRepository, ILogger<CreaTicketHandler\>\)

```csharp
public CreaTicketHandler(IMediator mediator, ITicketRepository ticketRepository, ILogger<CreaTicketHandler> logger)
```

#### Parameters

`mediator` IMediator

`ticketRepository` ITicketRepository

`logger` [ILogger](https://learn.microsoft.com/dotnet/api/microsoft.extensions.logging.ilogger\-1)<[CreaTicketHandler](WebApplication.Commands.CreaTicketHandler.md)\>

## Methods

### <a id="WebApplication_Commands_CreaTicketHandler_Handle_WebApplication_Commands_CreaTicket_System_Threading_CancellationToken_"></a> Handle\(CreaTicket, CancellationToken\)

Handles a request

```csharp
public Task<int> Handle(CreaTicket message, CancellationToken cancellationToken)
```

#### Parameters

`message` [CreaTicket](WebApplication.Commands.CreaTicket.md)

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

Cancellation token

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

Response from the request

