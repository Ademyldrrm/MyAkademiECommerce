using MyAkademiECommerce.Order.Application.Features.CQRS.Results;
using MyAkademiECommerce.Order.Application.Interfaces;
using MyAkademiECommerce.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAkademiECommerce.Order.Application.Features.CQRS.Handlers
{
    public class GetAddressQueryHandler
    {
        private readonly IRepository<Adress> _adressesRepository;

        public GetAddressQueryHandler(IRepository<Adress> adressesRepository)
        {
            _adressesRepository = adressesRepository;
        }
        public async Task<List<GetAddressQueryResult>> Handle()
        {
            var values = await _adressesRepository.GetAllAsync();
            return values.Select(x=> new GetAddressQueryResult
            {
                AdressID = x.AdressID,
                City = x.City,
                Detail=x.Detail,
                District = x.District,
                UserID=x.UserID,
            }).ToList();
        }
    }
}
