using AxitHome.ViewModels;
using Microsoft.Maui.Controls;

namespace AxitHome.Views.Pages
{
    public partial class RestaurantesPage : ContentPage
    {
        public RestaurantesPage()
        {
            InitializeComponent();
            BindingContext = new RestaurantesViewModel();
        }
    }
}
