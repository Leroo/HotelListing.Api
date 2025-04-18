using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.Api.Data
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Rating { get; set; }

        [ForeignKey(nameof(CountryId))]
        public int CountryId { get; set; }
        public Country? Country { get; set; } //This navigates back to the country using the Id above
        //One country, can have many hotels (One-to-Many relationship) 
    }
}
