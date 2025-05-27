using System;
using System.Collections.Generic;
using inventryUI.Models;

namespace inventryUI.Views
{
    public interface IProductView
    {
        string ProductName { get; }
        string SKU { get; }
        int Quantity { get; }
        decimal Price { get; }

        string SearchKeyword { get; }

        void SetProductList(List<Product> products);
        void ShowMessage(string message);
        void ClearFields();

        event EventHandler AddProduct;
        event EventHandler EditProduct;
        event EventHandler DeleteProduct;
        event EventHandler SearchProduct;
        event EventHandler LoadView;
    }
}
