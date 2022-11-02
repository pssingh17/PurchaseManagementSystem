using System;
using System.Collections.Generic;

namespace PurchaseManagementSystem.Models
{
    public enum Availability
    {
        In_Stock, Out_Of_Stock
    }
    public class Item
    {

        public int ID { get; set; }
        public string? ItemName { get; set; }

        public int Price { get; set; }
        public Availability? Availability { get; set; }

    }
}
