using HotelListing.Api.Contracts;
using HotelListing.Api.Data;
namespace HotelListing.Api.Repositoy
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        public HotelsRepository(HotelListingDbContext context) : base(context)
        {
        }
    }
}
