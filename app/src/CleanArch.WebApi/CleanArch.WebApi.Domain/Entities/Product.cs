﻿using CleanArch.WebApi.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.WebApi.Domain.Entities
{
    public class Product : EntityBase
    {
        public string Name { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
        public decimal Rate { get; set; }
    }
}
