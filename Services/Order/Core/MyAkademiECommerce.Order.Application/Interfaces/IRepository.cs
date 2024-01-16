﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyAkademiECommerce.Order.Application.Interfaces
{
    public interface IRepository<T>where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(int id);
        Task<T> CreateAsync(T entity);
        Task<List<T>> GetOrderByFiler(Expression<Func<T, bool>> filter);
    }
}
