﻿using System;
using System.Collections.Generic;

namespace PurchaseManagementSystem.Models
{
 
    public class Item
    {

        public int ID { get; set; }
        public string? ItemName { get; set; }

        public int Price { get; set; }

        public int Availability { get; set; }
    }
}
