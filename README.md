# eCommerce.Microservices.Events

Shared event contracts for inter-service communication within the eCommerce microservices architecture.

## Overview

This package contains immutable `record` types representing domain events (e.g., `OrderPlacedEvent`, `PaymentProcessedEvent`).

By sharing this package across publishers and subscribers, we ensure a strict schema contract and prevent serialization mismatch errors when messages are routed through our message broker.

## Usage

Simply install this package in your microservice and use the records to publish or consume events.

### Example

```csharp
var myEvent = new OrderCreatedEvent(
    OrderId: Guid.NewGuid(),
    CustomerId: customerId,
    TotalAmount: 99.99m,
    CreatedAtUtc: DateTime.UtcNow
);
```
