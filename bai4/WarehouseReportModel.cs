using System;

namespace bai4
{
    public class WarehouseReportModel
    {
        public string ItemCode { get; set; } = string.Empty;
        public string ItemName { get; set; } = string.Empty;
        public string WarehouseName { get; set; } = string.Empty;
        public int StockQuantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalValue => StockQuantity * UnitPrice;
    }
}