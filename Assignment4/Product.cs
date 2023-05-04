using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Product
    {
        public int pcode;
        public string pname;
        public int qty_in_stock;
        readonly float discount_allowed;
        public static string brand;
        public float pprice;

        public Product() {
            brand = "XYZ";
        }
        public Product(int pcode, string pname, int qty_in_stock, float discount_allowed, float pprice) {
            this.pcode = pcode;
            this.pname = pname;
            this.qty_in_stock = qty_in_stock;
            this.discount_allowed = discount_allowed;
            this.pprice = pprice;

        }
        public float getProductTotal(int qty) {
            return (this.pprice * (1 - this.discount_allowed))*qty;
        }
    }

}
