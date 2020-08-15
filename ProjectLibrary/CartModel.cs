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

using System.Collections.Generic;
using System.Linq;
using Nenov.DelegatesExample.ProjectLibrary;

namespace ProjectLibrary
{
  public class CartModel
  {
    public IList<ProductModel> Products { get; set; }

    /// <summary>
    /// Default constructor
    /// </summary>
    public CartModel()
    {
      Products = new List<ProductModel>();
    }

    public decimal GenerateTotal()
    {
      return Products.Sum(product => product.Price);
    }
  }
}
