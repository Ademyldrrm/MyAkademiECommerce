﻿namespace MyAkademiECommerce.Basket.Dtos
{
    public class BasketItemDto
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
