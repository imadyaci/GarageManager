using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProductTypeTypeModel
/// </summary>
public class ProductTypeTypeModel
{
    public string InsertProductType(ProductType product)
    {
        try
        {
            GarageDBEntities db = new GarageDBEntities();
            db.ProductTypes.Add(product);
            db.SaveChanges();
            return product.Name + "was succesfully inserted";

        }
        catch (Exception e)
        {
            return "Error:" + e;

        }
    }
    public string UpdateProductType(int id, ProductType product)
    {
        try
        {
            GarageDBEntities db = new GarageDBEntities();
            //Fetch object form db
            ProductType p = db.ProductTypes.Find(id);
            p.Name = product.Name;
           
            db.SaveChanges();
            return product.Name + "was succesfully updated";
        }
        catch (Exception e)
        {
            return "Error:" + e;

        }
    }
    public string DeleteProductType(int id)
    {
        try
        {
            GarageDBEntities db = new GarageDBEntities();
            ProductType product = db.ProductTypes.Find(id);
            db.ProductTypes.Attach(product);
            db.ProductTypes.Remove(product);
            db.SaveChanges();
            return product.Name + "was succesfully deleted";
        }

        catch (Exception e)
        {
            return "Error:" + e;

        }
    }
}