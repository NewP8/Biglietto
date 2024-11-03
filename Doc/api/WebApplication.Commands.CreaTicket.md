# <a id="WebApplication_Commands_CreaTicket"></a> Class CreaTicket

Namespace: [WebApplication.Commands](WebApplication.Commands.md)  
Assembly: Web.dll  

Richiesta di creazione nuovo ticket

```csharp
public class CreaTicket : IRequest<int>, IBaseRequest
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CreaTicket](WebApplication.Commands.CreaTicket.md)

#### Implements

IRequest<int\>, 
IBaseRequest

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Properties

### <a id="WebApplication_Commands_CreaTicket_Segnalatore"></a> Segnalatore

nome del segnalatore

```csharp
public string Segnalatore { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="WebApplication_Commands_CreaTicket_Segnalazione"></a> Segnalazione

```csharp
public string Segnalazione { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

