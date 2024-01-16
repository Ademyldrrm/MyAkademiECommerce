using AutoMapper;
using MongoDB.Driver;
using MyAkademiECommerce.Services.Catalog.Dtos.ProductDtos;
using MyAkademiECommerce.Services.Catalog.Models;
using MyAkademiECommerce.Services.Catalog.Settings;

namespace MyAkademiECommerce.Services.Catalog.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly IMongoCollection<Product> _productsCollection;
        private readonly IMapper _mapper;

        public ProductService(IMapper mapper,IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _productsCollection = database.GetCollection<Product>(_databaseSettings.ProductCollectionName);
            _mapper = mapper;
        }

        public async Task CreateProductAsync(CreateProductDto createProductDto)
        {
           var values=_mapper.Map<Product>(createProductDto);
            _productsCollection.InsertOneAsync(values);
        }

        public async Task DeleteProductAsync(string id)
        {
           await _productsCollection.DeleteOneAsync(x=>x.ProductID == id);
        }

        public async Task<List<ResultProductDto>> GetAllProductsAsync()
        {
            var values = await _productsCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultProductDto>>(values);
        }

        public async Task<ResultProductDto> GetProductByIdAsync(string id)
        {
            var values = await _productsCollection.Find(x => x.ProductID == id).FirstOrDefaultAsync();
            return _mapper.Map<ResultProductDto>(values);
        }

        public async Task UpdateProductAsync(UpdateProductDto updateProductDto)
        {
            var values = _mapper.Map<Product>(updateProductDto);
            await _productsCollection.FindOneAndReplaceAsync(x => x.ProductID == updateProductDto.ProductID,values);
        }
    }
}
