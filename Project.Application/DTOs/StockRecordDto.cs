﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.DTOs
{
    public class StockRecordDto
    {
        public string? ReferenceNum { get; set; }
        public int StockInQty { get; set; }
        public DateOnly StockInDate { get; set; }
        public Guid ProductId { get; set; }
        public string? ProductCode { get; set; }
        public string? ProductName { get; set; }
    }
}
