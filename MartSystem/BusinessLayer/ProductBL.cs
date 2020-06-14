using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuisnessObject;
using DataAccess;

namespace BusinessLayer
{
  public class ProductBL
    {
        ProductsDAL PDAL;

        public ProductBL() {
            PDAL = new ProductsDAL();
        }

        public SqlDataAdapter DisplayProducts() {
            return PDAL.DisplayProducts();
        }
        public void AddProduct(ProductBO P){
            PDAL.AddProduct(P);
        }
        public ProductBO UpdateProduct(ProductBO P){
            return PDAL.UpdateProduct(P);
        }
        public ProductBO RetrieveProductInfo(int id){
            return PDAL.RetrieveProductInfo(id);
        }
        public SqlDataAdapter RetrieveProductInfo(string name)
        {
            return PDAL.RetrieveProductInfo(name);
        }
        public List<SupplierBO> GetSuppliers()
        {
            return GetSuppliers();
        }
        public List<CategoryBO> GetCategories()
        {
            return GetCategories();

        }


    }
}
