//  --------------------------------------------------------------------------------------------------------------------
//  <copyright file="CartModel.cs">
//  (c) 2020 Nikolay Nenov, Solothurn, Switzerland, www.nenov.de
//  </copyright>
// 
//  <summary>
//    Cart model
//  </summary>
// 
//  <date>15-08-2020</date>
//  <author>Nikolay Nenov</author>
//  --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace Nenov.DelegatesExample.ProjectLibrary
{
  public class CartModel
  {
    /// <summary>
    /// Mention discount delegate method
    /// </summary>
    /// <param name="subTotal"></param>
    public delegate void MentionDiscount(decimal subTotal);

    public List<ProductModel> Products { get; set; }

    /// <summary>
    /// Default constructor
    /// </summary>
    public CartModel()
    {
      Products = new List<ProductModel>();
    }

    /// <summary>
    /// Generate total sum
    /// * Creating anonymous methods: anonymous Delegate
    /// * Creating anonymous methods: anonymous Func
    /// </summary>
    /// <returns></returns>
    public decimal GenerateTotal(MentionDiscount mentionDiscount, Func<List<ProductModel>, decimal, decimal> calculateDiscountedTotal)
    {
      decimal subTotal = Products.Sum(product => product.Price);

      // Use delegate method
      mentionDiscount?.Invoke(subTotal);

      // Use Func method
      return calculateDiscountedTotal(Products, subTotal);
    }
  }
}
