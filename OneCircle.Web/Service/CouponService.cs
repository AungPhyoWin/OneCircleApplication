using OneCircle.Web.Models;
using OneCircle.Web.Service.IService;

namespace OneCircle.Web.Service
{
    public class CouponService : ICouponService
    {
        public Task<ResponseDto?> CreateCouponsAsync(CouponDto couponDto)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto?> DeleteCouponsAsync(int couponId)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto?> GetAllCouponAsync(int couponId)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto?> GetCouponAsync(string couponCode)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto?> GetCouponByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto?> UpdateCouponsAsync(CouponDto couponDto)
        {
            throw new NotImplementedException();
        }
    }
}
