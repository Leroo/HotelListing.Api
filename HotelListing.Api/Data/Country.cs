namespace HotelListing.Api.Data
{
    public class Country
    {
        public int CountryId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public IList<Hotel> Hotels { get; set; } = []; //This is called a Naviagtion property
        //Ilist is not a traditional database type, it just means that this table can relate to many hotels
    }
}
