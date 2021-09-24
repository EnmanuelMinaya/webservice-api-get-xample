using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServiceDogApiSample.Services;
using WebServiceDogApiSample.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WebServiceDogApiSample.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FavouritePage : ContentPage
    {
        public FavouritePage()
        {
            InitializeComponent();
            BindingContext = new ImageViewModel(new DogApiService());
        }
    }
}