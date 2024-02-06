using MyAkademiECommerce.Basket.Dtos;

namespace MyAkademiECommerce.Basket.Services
{
    public interface IBasketService
    {
        Task<BasketTotalDto> GetBasketTotalAsync(string UserId);
        Task SaveBasket(BasketTotalDto basketTotalDto);
        Task DeleteBasket(string UserId);
    }
}
