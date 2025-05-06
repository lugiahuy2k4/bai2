﻿namespace Week2_2280601159.Models;
public class CartItem
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }

    public decimal TotalPrice => Quantity * Price;
}
