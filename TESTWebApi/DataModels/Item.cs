using System;
using System.Collections.Generic;

#nullable disable

namespace TESTWebApi.DataModels
{
    public partial class Item
    {
        public int ItemId { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public decimal? ItemPrice { get; set; }
        public int ItemQuantity { get; set; }
    }
}
