﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using VideoSharingService.Data.DTOs;
using X.PagedList;

namespace VideoSharingService.Data.IRepository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IList<T>> GetAll(
            Expression<Func<T, bool>> expression = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            List<string> includes = null
        );

        Task<IPagedList<T>> GetPagedList(RequestParams requestParams = null, List<string> includes = null);

        Task<T> Get(Expression<Func<T, bool>> expression, List<string> includes = null);

        Task Insert(T entity);

        Task Delete(int id);

        void Update(T entity);
    }
}
