using System.ComponentModel.DataAnnotations;

namespace HotelListing.Api.Models.Country
{
    public abstract class BaseCountryDto //abstract means it cannot be instentiated, it can only be used for inheritence
    {
        [Required]
        public string Name { get; set; }
        public string ShortName { get; set; }
    }
}
