using AutoMapper;
using Dapper;
using MyAkademiECommerce.Discount.Context;
using MyAkademiECommerce.Discount.Dtos;
using MyAkademiECommerce.Discount.Models;

namespace MyAkademiECommerce.Discount.Services
{
    public class DiscountService:IDiscountService
    {
        private readonly DapperContext _dapperContext;
       

        public DiscountService(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
           
        }

        public async Task CreateCouponAsync(CreateCouponDto createCouponDto)
        {
            string query = "insert into Coupons(Code,Rate,IsActive,ValidDate)values(@code,@rate,@isActive,@validDate)";
            var parameters = new DynamicParameters();
            parameters.Add("@code", createCouponDto.Code);
            parameters.Add("@rate", createCouponDto.Rate);
            parameters.Add("@isActive",true);
            parameters.Add("@validDate", DateTime.Now.AddDays(10));
            using (var connection=_dapperContext.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
        public async Task DeleteCouponAsync(int id)
        {
            string query = "Select * From  Coupons where CouponID=@couponıd";
            var parameters = new DynamicParameters();
            parameters.Add("@couponıd", id);
            using (var connection = _dapperContext.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultCouponDto>> GetAllCoupubAsync()
        {
            string query = "Select * From Coupons";
            using (var connection=_dapperContext.CreateConnection())
            {
                var values=await connection.QueryAsync<ResultCouponDto>(query);
                return values.ToList();
            }
        }

        public async Task<ResultCouponDto> GetCouponByIdAsync(int id)
        {
            string query = "Select * From Coupons where CouponID=@couponID";
            var parameters = new DynamicParameters();
            parameters.Add("@couponID", id);
            using (var connection=_dapperContext.CreateConnection())
            {
                var values=await connection.QueryFirstOrDefaultAsync<ResultCouponDto>(query,parameters);
                return values;
            }
        }

        public async Task UpdateCouponAsync(UpdateCouponDto updateCouponDto)
        {
            string query = "Update Coupons Set Code=@code,Rate=@rate,IsActive=@isActive,ValidDate=@validdate where CouponID=@couponID";
            var parameters = new DynamicParameters();
            parameters.Add("@code", updateCouponDto.Code);
            parameters.Add("@rate", updateCouponDto.Rate);
            parameters.Add("@isActive", updateCouponDto.IsActive);
            parameters.Add("@validDate", updateCouponDto.ValidDate);
            parameters.Add("@couponID", updateCouponDto.CouponID);
            using (var connection = _dapperContext.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
