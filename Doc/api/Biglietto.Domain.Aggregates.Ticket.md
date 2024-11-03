# <a id="Biglietto_Domain_Aggregates_Ticket"></a> Class Ticket

Namespace: [Biglietto.Domain.Aggregates](Biglietto.Domain.Aggregates.md)  
Assembly: Domain.dll  

Aggregato Ticket

```csharp
public class Ticket : Entity
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](Biglietto.Domain.Entity.md) ← 
[Ticket](Biglietto.Domain.Aggregates.Ticket.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Properties

### <a id="Biglietto_Domain_Aggregates_Ticket_DataApertura"></a> DataApertura

```csharp
public DateTime DataApertura { get; set; }
```

#### Property Value

 [DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)

### <a id="Biglietto_Domain_Aggregates_Ticket_Risposta"></a> Risposta

```csharp
public string Risposta { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Biglietto_Domain_Aggregates_Ticket_Segnalatore"></a> Segnalatore

Nome del soggetto segnalatore

```csharp
public string Segnalatore { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Biglietto_Domain_Aggregates_Ticket_Segnalazione"></a> Segnalazione

```csharp
public string Segnalazione { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Biglietto_Domain_Aggregates_Ticket_Stato"></a> Stato

```csharp
public StatoTicket Stato { get; set; }
```

#### Property Value

 [StatoTicket](Biglietto.Domain.Aggregates.StatoTicket.md)

