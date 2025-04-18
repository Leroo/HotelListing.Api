using Microsoft.EntityFrameworkCore;

namespace HotelListing.Api.Data
{
    public class HotelListingDbContext: DbContext
    {
        public HotelListingDbContext(DbContextOptions<HotelListingDbContext> options ): base(options)
        {
            //The options will be passed at the start of the program 
            //Also the logic of the options being passed is in the base class, the DbContext
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; } //Telling EF that I want a table called Hotels based on the Hotel model
    }
}
