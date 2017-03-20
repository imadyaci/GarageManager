﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class Cart
{
    public int ID { get; set; }
    public string ClientID { get; set; }
    public int ProductID { get; set; }
    public int Amount { get; set; }
    public Nullable<System.DateTime> DatePruchased { get; set; }
    public bool IsInCart { get; set; }

    public virtual Product Product { get; set; }
}

public partial class Product
{
    public Product()
    {
        this.Carts = new HashSet<Cart>();
    }

    public int Id { get; set; }
    public int TypeId { get; set; }
    public string Name { get; set; }
    public Nullable<int> Price { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }

    public virtual ICollection<Cart> Carts { get; set; }
    public virtual ProductType ProductType { get; set; }
}

public partial class ProductType
{
    public ProductType()
    {
        this.Products = new HashSet<Product>();
    }

    public int Id { get; set; }
    public string Name { get; set; }

    public virtual ICollection<Product> Products { get; set; }
}