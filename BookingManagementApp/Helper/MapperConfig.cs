using AutoMapper;
using BookingManagementApp.DTOs;
using BookingManagementApp.Models;

namespace BookingManagementApp.Helper
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Booking, BookingDto>().ReverseMap();
        }
    }
}
