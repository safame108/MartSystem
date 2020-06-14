﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuisnessObject;

namespace DataAccess
{
    public class ProductsDAL
    {
        SqlConnection conn;
        SqlCommand cmd;

        public SqlDataAdapter DisplayProducts()
        {
            conn = new SqlConnection(@"data source=DESKTOP-FBIGVNP;initial catalog=MartSystem;integrated security=True");

            conn.Open();
            String Query = "EXEC ProductsDisplay";
            SqlDataAdapter sqa = new SqlDataAdapter(Query, conn);
            return sqa;
        }

        public void AddProduct(ProductBO P)
        {
            using (conn = new SqlConnection(@"data source=DESKTOP-FBIGVNP;initial catalog=MartSystem;integrated security=True"))
            {
                conn.Open();
                string Query = "INSERT INTO Products VALUES(@id,@name,@supplierid,@categoryid,@productdesc,@price,@expire,@quantity)";
                cmd = new SqlCommand(Query, conn);
                cmd.Parameters.Add("@id", P.ProductID);
                cmd.Parameters.Add("@name", P.ProductName);
                cmd.Parameters.Add("@supplierid", P.SupplierID);
                cmd.Parameters.Add("@categoryid", P.CategoryID);
                cmd.Parameters.Add("@productdesc", P.ProductDesc);
                cmd.Parameters.Add("@price", P.UnitPrice);
                cmd.Parameters.Add("@expire", P.ExpireDate);
                cmd.Parameters.Add("@quantity", P.TotalQuantity);

                cmd.ExecuteNonQuery();
                conn.Close();

            }

        }

        public ProductBO UpdateProduct(ProductBO P) {

            using (conn = new SqlConnection(@"data source=DESKTOP-FBIGVNP;initial catalog=MartSystem;integrated security=True"))
            {
                conn.Open();
                string Query = "UPDATE Products  SET Unit_Price = @price,Product_Total_Quantity= @quantity)";
                cmd = new SqlCommand(Query, conn);
              //  cmd.Parameters.Add("@id", P.ProductID);
               // cmd.Parameters.Add("@name", P.ProductName);
               // cmd.Parameters.Add("@supplierid", P.SupplierID);
               // cmd.Parameters.Add("@categoryid", P.CategoryID);
               // cmd.Parameters.Add("@productdesc", P.ProductDesc);
                cmd.Parameters.Add("@price", P.UnitPrice);
                //cmd.Parameters.Add("@expire", P.ExpireDate);
                cmd.Parameters.Add("@quantity", P.TotalQuantity);

                cmd.ExecuteNonQuery();
                conn.Close();

            }
            return P;
        }
        public ProductBO RetrieveProductInfo(int id)
        { 
            ProductBO P = new ProductBO();
            P.ProductID = id;
            using (conn = new SqlConnection(@"data source=DESKTOP-FBIGVNP;initial catalog=MartSystem;integrated security=True"))
            {
                conn.Open();
                String Query = "SELECT * FROM Products WHERE Product_ID = @id";
                cmd = new SqlCommand(Query, conn);
                cmd.Parameters.Add("@id", id);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        P.ProductName= reader["Product_Name"].ToString();
                        P.SupplierID = Convert.ToInt32(reader["Supplier_ID"].ToString());
                        P.CategoryID = Convert.ToInt32(reader["Category_ID"].ToString());
                        P.ProductDesc = reader["Product_desc"].ToString();
                        P.UnitPrice = Convert.ToDouble(reader["Unit_Price"].ToString());
                        P.ExpireDate = reader["Expire_Date"].ToString();
                        P.TotalQuantity = Convert.ToInt32(reader["Product_Total_Quantity"].ToString());


                    }
                }

                cmd.ExecuteNonQuery();
                conn.Close();
            }

            return P;
    }
        public SqlDataAdapter RetrieveProductInfo(String name) {
            ProductBO P = new ProductBO();
            P.ProductName = name;

            conn = new SqlConnection(@"data source=DESKTOP-FBIGVNP;initial catalog=MartSystem;integrated security=True");

            conn.Open();
            String Query = "SELECT * FROM Products WHERE Product_Name LIKE '%" + name + "%'";
            SqlDataAdapter sqa = new SqlDataAdapter(Query, conn);
            return sqa;
        }
        ///showing properids
        //public int IdSelector (string option,string name){
        //    int id=-1;
        //    string Query;
        //    using (conn = new SqlConnection(@"data source=DESKTOP-FBIGVNP;initial catalog=MartSystem;integrated security=True"))
        //    {
        //        conn.Open();
        //        switch (option) {
        //            case "Supplier":
        //                 Query = "SELECT Supplier_ID FROM Supplier WHERE Supplier_Name = '"+name+"'";
        //                cmd = new SqlCommand(Query, conn);
        //                using (SqlDataReader reader = cmd.ExecuteReader())
        //                {
        //                    if (reader.Read())
        //                    {
        //                        id = Convert.ToInt32(reader["Supplier_ID"].ToString());
                             
        //                    }
        //                }
        //                cmd.ExecuteNonQuery();
        //                conn.Close();
        //                break;
        //            case "Category":
        //                Query = "SELECT Category_ID FROM Product_Categories WHERE Category_Name = '" + name + "'";
        //                cmd = new SqlCommand(Query, conn);
        //                using (SqlDataReader reader = cmd.ExecuteReader())
        //                {
        //                    if (reader.Read())
        //                    {
        //                        id = Convert.ToInt32(reader["Supplier_ID"].ToString());

        //                    }
        //                }
        //                cmd.ExecuteNonQuery();
        //                conn.Close();
        //                break;
        //        }
           
        //    }
        //        return id;
        //}

        public List<SupplierBO> GetSuppliers() {
            List<SupplierBO> s = new List<SupplierBO>();
            string Query;
            conn = new SqlConnection(@"data source=DESKTOP-FBIGVNP;initial catalog=MartSystem;integrated security=True");
            
                conn.Open();
                Query = "EXEC SuppliersList";
                cmd = new SqlCommand(Query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                SupplierBO ss = new SupplierBO();
                    ss.ID=Convert.ToInt32(reader["Supplier_ID"].ToString());
                    ss.Name = reader["Supplier_Name"].ToString();
                    ss.Contact = reader["Contact"].ToString();
                    s.Add(ss);
                }
                cmd.ExecuteNonQuery();

            return s;

        }

        public List<CategoryBO> GetCategories() {
     List<CategoryBO> s = new List<CategoryBO>();
                string Query;
            conn = new SqlConnection(@"data source=DESKTOP-FBIGVNP;initial catalog=MartSystem;integrated security=True");
            
                conn.Open();
            Query = "EXEC CategoryList";
            cmd = new SqlCommand(Query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                CategoryBO ss = new CategoryBO();
                ss.ID = Convert.ToInt32(reader["Category_ID"].ToString());
                ss.Name = reader["Category_Name"].ToString();
                s.Add(ss);
            }
            cmd.ExecuteNonQuery();

            return s;

    }

}
}