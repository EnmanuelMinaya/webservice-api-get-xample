using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WebServiceDogApiSample.Models;
using Xamarin.Essentials;

namespace WebServiceDogApiSample.Services
{
    public class DogApiService : IDogApiService
    {
        private const string apiAccessKey = "AGREGAR API KEY AQUI";
        private const string favoriteId = "12290";
           public async Task<FavouriteImageResponse> GetFavourite()
        {
            if(Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                HttpClient httpClient = new HttpClient();

                HttpRequestMessage request = new HttpRequestMessage();
                request.RequestUri = new System.Uri($"https://api.thedogapi.com/v1/favourites/{favoriteId}");
                request.Method = HttpMethod.Get;
                request.Headers.Add("x-api-key", apiAccessKey);

                var response = await httpClient.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    var responseString = await response.Content.ReadAsStringAsync();

                    var favouriteImageResponse = JsonConvert.DeserializeObject<FavouriteImageResponse>(responseString);

                    return favouriteImageResponse;
                }
                return null;
            }
            else
            {
               await App.Current.MainPage.DisplayAlert("Alerta","No se pudo establecer conexión a internet","ok");
               return null;
            }


        }
    }
}
