using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebServiceDogApiSample.Models;

namespace WebServiceDogApiSample.Services
{
    public interface IDogApiService
    {
        Task<FavouriteImageResponse> GetFavourite();
    }
}
