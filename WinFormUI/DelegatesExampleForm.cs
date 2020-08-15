//  --------------------------------------------------------------------------------------------------------------------
//  <copyright file="DelegatesExampleForm.cs">
//  (c) 2020 Nikolay Nenov, Solothurn, Switzerland, www.nenov.de
//  </copyright>
// 
//  <summary>
//    WinForms application main
//  </summary>
// 
//  <date>15-08-2020</date>
//  <author>Nikolay Nenov</author>
//  --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Nenov.DelegatesExample.ProjectLibrary;

namespace Nenov.DelegatesExample.WinFormUI
{
  public partial class DelegatesExampleForm : Form
  {
    private readonly CartModel _cart;

    public DelegatesExampleForm()
    {
      InitializeComponent();

      // Initialize cart products
      _cart = new CartModel();
      InitCartWithDemoData();
    }

    /// <summary>
    /// Initial cart object with demo data
    /// </summary>
    private void InitCartWithDemoData()
    {
      _cart.Products.Add(new ProductModel { Name = "Milk", Price = 1.35M });
      _cart.Products.Add(new ProductModel { Name = "Cheese", Price = 3.21M });
      _cart.Products.Add(new ProductModel { Name = "Pizza", Price = 5.24M });
      _cart.Products.Add(new ProductModel { Name = "Potatoes", Price = 3.45M });
      _cart.Products.Add(new ProductModel { Name = "Bananas", Price = 1.32M });
    }

    /// <summary>
    /// Message button click command
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void messageButton_Click(object sender, EventArgs e)
    {
      decimal total = _cart.GenerateTotal(ShowSubTotalAlert, CalculateLeveledDiscount, ShowDiscountAlert);
      MessageBox.Show($"The total is {total:C2}");
    }

    /// <summary>
    /// Calc button click command
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void calcButton_Click(object sender, EventArgs e)
    {
      decimal total = _cart.GenerateTotal(
        (subTotal) => subtotalTextBox.Text = $"{subTotal:C2}",
        (products, subTotal) => products.Count > 3 ? subTotal - 3M : subTotal,
        (message) => { }
      );

      totalTextBox.Text = $"{total:C2}";
    }

    /// <summary>
    /// Implement delegate method in a WinFormUI application
    /// </summary>
    /// <param name="subTotal"></param>
    private void ShowSubTotalAlert(decimal subTotal)
    {
      MessageBox.Show($"The subtotal is: {subTotal:C2}");
    }

    /// <summary>
    /// Implement Func method in a WinFormUI application
    /// </summary>
    /// <param name="products"></param>
    /// <param name="subTotal"></param>
    /// <returns></returns>
    private static decimal CalculateLeveledDiscount(List<ProductModel> products, decimal subTotal)
    {
      if (products.Count > 3)
      {
        subTotal -= 3M;
      }

      return subTotal;
    }

    /// <summary>
    /// Implement Action method in a WinFormUI application
    /// </summary>
    /// <param name="message"></param>
    private void ShowDiscountAlert(string message)
    {
      MessageBox.Show(message);
    }
  }
}
