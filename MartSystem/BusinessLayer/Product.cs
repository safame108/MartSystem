using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class Product
    {
        public String ProductID { get; set; }
        public String ProductName { get; set; }
        public String SupplierID { get; set; }
        public String CategoryID { get; set; }
        public String ProductDesc { get; set; }
        public Double UnitPrice { get; set; }
        public DateTime ExpireDate { get; set; }
        public int TotalQuantity { get; set; }
    }
}
