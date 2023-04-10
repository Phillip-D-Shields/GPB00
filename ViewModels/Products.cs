using System;
using CommunityToolkit.Mvvm.ComponentModel;
using GPB00.Models;

namespace GPB00.ViewModels
{
  public partial class ProductsViewModel : ObservableObject
  {
    [ObservableProperty]
    List<Product> products;

    public ProductsViewModel()
    {
      LoadProducts();
    }

    private void LoadProducts()
    {
      Products = new()
            {
                new Product(
                    Name: "test product 00",
                    Description: "test description 00.test description 00.test description 00.test description 00. ",
                    Cost: 8.50m,
                    CreatedDateTime: new DateTime(),
                    BulletPoints: new List<string> {"wood type", "common use", "feature00", "feature01" },
                    Image: new Uri("https://picsum.photos/200/300")),
                new Product(
                    Name: "test product 01",
                    Description: "test description 01.test description 01.test description 01.test description 01. ",
                    Cost: 8.50m,
                    CreatedDateTime: new DateTime(),
                    BulletPoints: new List<string> {"wood type", "common use", "feature00", "feature01" },
                    Image: new Uri("https://picsum.photos/200/300"))
            };
    }
  }
}

