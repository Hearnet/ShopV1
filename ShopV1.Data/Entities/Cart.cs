﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShopV1.Data.Entities
{
    public class Cart
    {
        public int Id { set; get; }
        public int ProductId { set; get; }
        public int Quantity { set; get; }
        public decimal Price { set; get; }
    }
}
