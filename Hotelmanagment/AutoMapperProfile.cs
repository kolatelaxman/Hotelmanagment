using AutoMapper;
using Hotelmanagment.Models;
using Hotelmanagment.Models.Dtos;

namespace Hotelmanagment
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Hotel, HotelDto>().ReverseMap();
        }
    }
}
