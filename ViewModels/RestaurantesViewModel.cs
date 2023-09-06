using System.Collections.ObjectModel;
using System.Windows.Input;
using AxitHome.Models;
using AxitHome.ViewModels.Base;
using Microsoft.Maui.Controls;

namespace AxitHome.ViewModels
{
    public class RestaurantesViewModel : BaseViewModel
    {
        public ICommand GoBackCommand { get; private set; }

        public RestaurantesViewModel()
        {
            GoBackCommand = new Command(GoBack);

            // Listado de restaurantes
            var restaurantes = new List<Restaurante>
            {
                new Restaurante
                {
                    Name = "Sushi bar snack",
                    Image = "URL_IMAGEN_SUSHI_BAR_SNACK"
                },
                new Restaurante
                {
                    Name = "Restaurant Trattoria",
                    Image = "URL_IMAGEN_TRATTORIA"
                },
                new Restaurante
                {
                    Name = "Restaurant Principal",
                    Image = "URL_IMAGEN_PRINCIPAL"
                },
                new Restaurante
                {
                    Name = "Bar",
                    Image = "URL_IMAGEN_BAR"
                }
            };

            Restaurantes = new ObservableCollection<Restaurante>(restaurantes);
        }

        ObservableCollection<Restaurante> listRestaurantes;
        public ObservableCollection<Restaurante> Restaurantes
        {
            get { return listRestaurantes; }
            set { SetProperty(ref listRestaurantes, value); }
        }

        private void GoBack()
        {
            if (Shell.Current.Navigation.NavigationStack.Count > 1)
            {
                Shell.Current.Navigation.PopAsync();
            }
            else
            {
                Shell.Current.GoToAsync("//Inicio");
            }
        }
    }
}

