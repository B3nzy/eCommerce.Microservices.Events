using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Microservices.Events.Order;

public class OrderPlaced
{
    public Guid OrderId { get; set; }
    public Guid UserId { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalBill { get; set; }
    public List<OrderItem>? OrderItems { get; set; }
}

public class OrderItem
{
    public Guid ProductId { get; set; }
    public decimal UnitPrice { get; set; }
    public int Quantity { get; set; }
    public decimal TotalPrice { get; set; }
}