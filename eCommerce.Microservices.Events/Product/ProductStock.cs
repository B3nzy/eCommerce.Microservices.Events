using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Microservices.Events.Product;

public class ProductStock
{
    public Guid ProductId { get; set; }
    public int QuantityInStock { get; set; }
}
