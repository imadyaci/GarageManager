using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CartModel
/// </summary>
public class CartModel
{
    public string InsertCart(Cart cart)
    {
        try
        {
            GarageDBEntities db = new GarageDBEntities();
            db.Carts.Add(cart);
            db.SaveChanges();
            return cart.DatePruchased + "was succesfully inserted";

        }
        catch (Exception e)
        {
            return "Error:" + e;

        }
    }
    public string UpdateCart(int id, Cart cart)
    {
        try
        {
            GarageDBEntities db = new GarageDBEntities();
            //Fetch object form db
            Cart p = db.Carts.Find(id);
            p.DatePruchased = cart.DatePruchased;
            p.Amount = cart.Amount;
            p.ClientID = cart.ClientID;
            p.IsInCart = cart.IsInCart;
            p.ProductID = cart.ProductID;
            
            db.SaveChanges();
            return cart.DatePruchased + "was succesfully updated";
        }
        catch (Exception e)
        {
            return "Error:" + e;

        }
    }
    public string DeleteCart(int id)
    {
        try
        {
            GarageDBEntities db = new GarageDBEntities();
            Cart cart = db.Carts.Find(id);
            db.Carts.Attach(cart);
            db.Carts.Remove(cart);
            db.SaveChanges();
            return cart.DatePruchased + "was succesfully deleted";
        }

        catch (Exception e)
        {
            return "Error:" + e;

        }
    }
}