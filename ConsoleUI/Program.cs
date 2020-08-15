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
using Nenov.DelegatesExample.ProjectLibrary;
using ProjectLibrary;

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

      Console.WriteLine($"The total for the cart is: {_cart.GenerateTotal()}");

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
    }
  }
}
