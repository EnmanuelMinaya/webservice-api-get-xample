using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using WebServiceDogApiSample.Services;
using Xamarin.Forms;

namespace WebServiceDogApiSample.ViewModels
{
    public class ImageViewModel : BaseViewModel
    {
        public string Url { get; set; }
        public ICommand ShowFavoriteCommand { get; }

        public ImageViewModel(IDogApiService dogApiService)
        {
            _dogApiService = dogApiService;
            ShowFavoriteCommand = new Command(OnShow);
        }
        public ImageViewModel()
        {

        }

        private async void OnShow()
        {
            var FavoriteResponse = await _dogApiService.GetFavourite();
            if (FavoriteResponse != null)
            {
                Url=FavoriteResponse.Image.Url;
            }

        }

        IDogApiService _dogApiService;

    }
}
