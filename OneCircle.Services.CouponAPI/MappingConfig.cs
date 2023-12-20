using AutoMapper;
using OneCircle.Services.CouponAPI.Models;
using OneCircle.Services.CouponAPI.Models.Dto;

namespace OneCircle.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>();
                config.CreateMap<Coupon, CouponDto>();

            });
            return mappingConfig;
        }
    }
}
