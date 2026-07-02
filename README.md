# eCommerce.Microservices.Events

Shared event contracts for inter-service communication within the `eCommerceSolution` microservices architecture.

## 🚀 Overview

This repository acts as the single source of truth for all event contracts exchanged across our microservices ecosystem. It contains immutable `record` types representing core domain events (such as order placements, stock adjustments, and inventory updates). 

By referencing this shared package across both publishers and subscribers, we enforce a strict schema contract that prevents serialization mismatches and message routing errors when messages travel through **RabbitMQ** and **MassTransit**.

---

## 🛠️ Tech Stack

* **Runtime:** .NET Core 8.0 / 10.0 (Backward compatible)
* **Message Broker:** RabbitMQ
* **Transit Framework:** MassTransit
* **Language:** C#

---

## 📥 Usage

Simply install or reference this project/package within your respective publisher or subscriber microservices to safely transmit cross-domain messages.

### Example Contract
```csharp
public record ProductStock
{
    public Guid ProductId { get; init; }
    public int QuantityInStock { get; init; }
    public DateTime LastUpdated { get; init; }
}
