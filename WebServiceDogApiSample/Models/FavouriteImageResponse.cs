using System;

namespace WebServiceDogApiSample.Models
{
    public class FavouriteImageResponse
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string ImageId { get; set; }
        public string SubId { get; set; }
        public DateTime CreatedAt { get; set; }
        public FavouriteImage Image { get; set; }
    }
}
