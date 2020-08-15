//  --------------------------------------------------------------------------------------------------------------------
//  <copyright file="Program.cs">
//  (c) 2020 Nikolay Nenov, Solothurn, Switzerland, www.nenov.de
//  </copyright>
// 
//  <summary>
//    Console application main
//  </summary>
// 
//  <date>15-08-2020</date>
//  <author>Nikolay Nenov</author>
//  --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Nenov.DelegatesExample.ProjectLibrary;

namespace Nenov.DelegatesExample.ConsoleUI
{
  public class Program
  {
    private static CartModel _cart = new CartModel();

    /// <summary>
    /// Application main method
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args)  
    {
      Console.WriteLine("*** Delegates example ***");
      InitCartWithDemoData();

      // Use Delegate method
      // Use Func method
      // Use Action method
      Console.WriteLine($"The total for the cart is: {_cart.GenerateTotal(SubTotalAlert, CalculateLeveledDiscount, AlertUser):C2}");
      Console.WriteLine();
      Console.WriteLine("=== Use anonymous methods ===");

      // Use anonymous Delegate
      // Use anonymous Func
      // Use anonymous Action
      decimal total = _cart.GenerateTotal(
        (subTotal) => Console.WriteLine($"The subtotal for cart 2 is: {subTotal:C2}"),
        (products, subTotal) =>
        {
          if (products.Count > 3)
          {
            return subTotal * 0.5M;
          }

          return subTotal;
        },
        (message) => Console.WriteLine($"Cart 2 alert: {message}")
        );
      Console.WriteLine($"The total for cart 2 is: {total:C2}");

      Console.ReadKey();
    }

    /// <summary>
    /// Initial cart object with demo data
    /// </summary>
    private static void InitCartWithDemoData()
    {
      _cart.Products.Add(new ProductModel{Name = "Milk", Price = 1.35M});
      _cart.Products.Add(new ProductModel { Name = "Cheese", Price = 3.21M});
      _cart.Products.Add(new ProductModel { Name = "Pizza", Price = 5.24M});
      _cart.Products.Add(new ProductModel { Name = "Potatoes", Price = 3.45M});
      _cart.Products.Add(new ProductModel { Name = "Bananas", Price = 1.32M });
    }

    /// <summary>
    /// Implement delegate method in a ConsoleUI application
    /// </summary>
    /// <param name="subTotal"></param>
    private static void SubTotalAlert(decimal subTotal)
    {
      Console.WriteLine($"The subtotal is: {subTotal:C2}");
    }

    /// <summary>
    /// Implement Func method in a Console UI application
    /// </summary>
    /// <param name="products"></param>
    /// <param name="subTotal"></param>
    /// <returns></returns>
    private static decimal CalculateLeveledDiscount(List<ProductModel> products, decimal subTotal)
    {
      if (subTotal > 100)
      {
        subTotal *= 0.80M;
      }
      if (subTotal > 50)
      {
        subTotal *= 0.85M;
      }
      if (subTotal > 10)
      {
        subTotal *= 0.95M;
      }

      return subTotal;
    }

    /// <summary>
    /// Implement Action method in a ConsoleUI application
    /// </summary>
    /// <param name="message"></param>
    private static void AlertUser(string message)
    {
      Console.WriteLine(message);
    }
  }
}
