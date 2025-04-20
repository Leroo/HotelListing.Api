namespace HotelListing.Api.Models.Hotel
{
    //For updating we will use the Hotel DTO, but for creating we need the create DTO because 
    //we don't want to include the ID when asking to user t create.
    public class CreateHotelDto : BaseHotelDto
    {
        
    }
}