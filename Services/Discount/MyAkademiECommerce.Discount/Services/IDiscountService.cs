using MyAkademiECommerce.Discount.Dtos;

namespace MyAkademiECommerce.Discount.Services
{
    public interface IDiscountService
    {
        Task<List<ResultCouponDto>> GetAllCoupubAsync();
        Task CreateCouponAsync(CreateCouponDto createCouponDto);
        Task UpdateCouponAsync(UpdateCouponDto updateCouponDto);
        Task DeleteCouponAsync(int id);
        Task <ResultCouponDto> GetCouponByIdAsync(int id);
    }
}
