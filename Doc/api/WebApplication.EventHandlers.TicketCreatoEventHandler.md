# <a id="WebApplication_EventHandlers_TicketCreatoEventHandler"></a> Class TicketCreatoEventHandler

Namespace: [WebApplication.EventHandlers](WebApplication.EventHandlers.md)  
Assembly: Web.dll  

```csharp
public class TicketCreatoEventHandler : INotificationHandler<TicketCreato>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TicketCreatoEventHandler](WebApplication.EventHandlers.TicketCreatoEventHandler.md)

#### Implements

INotificationHandler<TicketCreato\>

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="WebApplication_EventHandlers_TicketCreatoEventHandler__ctor_Microsoft_Extensions_Logging_ILogger_WebApplication_EventHandlers_TicketCreatoEventHandler__"></a> TicketCreatoEventHandler\(ILogger<TicketCreatoEventHandler\>\)

```csharp
public TicketCreatoEventHandler(ILogger<TicketCreatoEventHandler> _logger)
```

#### Parameters

`_logger` [ILogger](https://learn.microsoft.com/dotnet/api/microsoft.extensions.logging.ilogger\-1)<[TicketCreatoEventHandler](WebApplication.EventHandlers.TicketCreatoEventHandler.md)\>

## Methods

### <a id="WebApplication_EventHandlers_TicketCreatoEventHandler_Handle_Biglietto_Domain_Events_TicketCreato_System_Threading_CancellationToken_"></a> Handle\(TicketCreato, CancellationToken\)

Handles a notification

```csharp
public Task Handle(TicketCreato evento, CancellationToken token)
```

#### Parameters

`evento` TicketCreato

`token` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

