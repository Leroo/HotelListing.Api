﻿using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.Api.Models.Hotel
{
    public class HotelDto : BaseHotelDto
    {
        public int Id { get; set; }
    }
}