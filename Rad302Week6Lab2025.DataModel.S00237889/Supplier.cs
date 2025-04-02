﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rad302Week6Lab2025.DataModel.S00237889
{
    public class Supplier
    {

        public int SupplierID { get; set; }
        public string CompanyName { get; set; }

        public string ContactName { get; set; }

        public string ContactTitle { get; set; }
        public string Address { get; set; }

        public string City { get; set; }
        public string Region { get; set; }

        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public List<Product> SupplierProducts { get; set; } = new List<Product>();
    }
}
