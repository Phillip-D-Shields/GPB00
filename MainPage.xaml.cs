using GPB00.ViewModels;

namespace GPB00;

public partial class MainPage : ContentPage
{

  public MainPage()
  {
    InitializeComponent();
    BindingContext = new ProductsViewModel();
  }

}


