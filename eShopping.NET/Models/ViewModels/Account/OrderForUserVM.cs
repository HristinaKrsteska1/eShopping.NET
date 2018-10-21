﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eShopping.NET.Models.ViewModels.Account
{
    public class OrderForUserVM
    {
        public int OrderNumber { get; set; }        
        public decimal Total { get; set; }
        public Dictionary<string, int> ProductsAndQuantity { get; set; }
        public DateTime DateCreated { get; set; }
    }
}