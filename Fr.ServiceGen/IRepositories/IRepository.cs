using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Fr.IRepositories;
using System.Data.Common;
using System.Data;
using System.Data.Entity.Core.Objects;

namespace Fr.IRepositories
{
     public interface IRepository<TEntity>  where TEntity:class
    {
          IQueryable<TEntity> Source { get; }
          IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> expression);

          int Count(Expression<Func<TEntity, bool>> expression);

          IQueryable<TEntity> FindForPaging(int size, int index, Expression<Func<TEntity, bool>> expression, out int total);

          IQueryable<TEntity> FindForPaging(int size, int index, IQueryable<TEntity> source, out int total);

          bool Insert(TEntity entity);

          TEntity InsertReturnEntity(TEntity entity);

          bool Insert(IEnumerable<TEntity> batch);

          bool Save(TEntity entity);

          bool Delete(TEntity entity);

          bool Delete(IEnumerable<TEntity> batch);


          bool Delete(Expression<Func<TEntity, bool>> expression);

          IQueryable<T> ExecuteSql<T>(string sql, params object[] paramers);

          IQueryable<T> ExecuteFunction<T>(string funcName, params  ObjectParameter[] paramers);
          DataTable ExecuteFunction(string funcName, params DbParameter[] paramers);
    }
}
