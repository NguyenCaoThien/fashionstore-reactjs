﻿using FashionStore.Api.Controllers.Data;
using FashionStore.Api.Controllers.Models;

namespace FashionStore.Api.Models
{
    public class BasketItem
    {
        public int  Id { get; set; }
        public int Quantity{ get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; } = new Product();
        public int BasketId { get; set; }
        public Basket? Basket { get; set; }
    }
}
