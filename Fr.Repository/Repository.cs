using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Fr.IRepositories;

namespace Fr.Repositories
{

    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {


        private static EfContext CoreContext
        {
            get
            {
                string _readKey = "_readConnection";
                string _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
                EfContext collection = CallContext.GetData(_readKey) as EfContext; 

                if (collection == null)
                {
                    collection = new EfContext(_connectionString);
                    CallContext.SetData(_readKey, collection);
                }
                return collection;
            }
        }

        public virtual IQueryable<TEntity> Source
        {
            get { return CoreContext.Set<TEntity>(); }
        }

        public virtual IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> expression)
        {
            return CoreContext.Set<TEntity>().Where(expression);
        }

        public virtual int Count(Expression<Func<TEntity, bool>> expression)
        {
            return CoreContext.Set<TEntity>().Count(expression);
        }

        public virtual IQueryable<TEntity> FindForPaging(int size, int index, Expression<Func<TEntity, bool>> expression, out int total)
        {
            return FindForPaging(size, index, this.Find(expression), out total);
        }

        public virtual IQueryable<TEntity> FindForPaging(int size, int index, IQueryable<TEntity> source, out int total)
        {
            if (index <= 0)
                index = 1;
            var temp = source.Skip((index - 1) * size).Take(size);
            total = source.Count();
            return temp;
        }

        public virtual bool Insert(TEntity entity)
        {
            if (entity == null)
                throw new Exception("新增对象不能为空");
            CoreContext.Set<TEntity>().Add(entity);
            return CoreContext.SaveChanges() > 0;
        }

        /// <summary>
        /// 插入并返回最新对象
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual TEntity InsertReturnEntity(TEntity entity)
        {
            if (entity == null)
                throw new Exception("新增对象不能为空");
            CoreContext.Set<TEntity>().Add(entity);
            CoreContext.SaveChanges();
            return entity;
        }

        public virtual bool Insert(IEnumerable<TEntity> batch)
        {
            CoreContext.Set<TEntity>().AddRange(batch);
            return CoreContext.SaveChanges() > 0;
        }

        public virtual bool Save(TEntity entity)
        {
            if (entity == null)
                throw new Exception("保存对象不能为空");
            CoreContext.Entry<TEntity>(entity).State = System.Data.Entity.EntityState.Modified;
            return CoreContext.SaveChanges() > 0;
        }

        public virtual bool Delete(TEntity entity)
        {
            if (entity == null)
                throw new Exception("删除对象不能为空");
            CoreContext.Set<TEntity>().Remove(entity);
            return CoreContext.SaveChanges() > 0;
        }

        public virtual bool Delete(IEnumerable<TEntity> batch)
        {
            CoreContext.Set<TEntity>().RemoveRange(batch);
            return CoreContext.SaveChanges() > 0;
        }

        public virtual bool Delete(Expression<Func<TEntity, bool>> expression)
        {
            return this.Delete(this.Find(expression));
        }

        /// <summary>
        /// 执行查询类SQL语句
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="sql"></param>
        /// <param name="paramers"></param>
        /// <returns></returns>
        public virtual IQueryable<T> ExecuteSql<T>(string sql, params object[] paramers)
        {
            return CoreContext.Database.SqlQuery<T>(sql, paramers).AsQueryable();
        }

        /// <summary>
        /// 执行查询类存储过程
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="funcName"></param>
        /// <param name="paramers"></param>
        /// <returns></returns>
        public virtual IQueryable<T> ExecuteFunction<T>(string funcName, params  ObjectParameter[] paramers)
        {
            return ((IObjectContextAdapter)CoreContext).ObjectContext
                .ExecuteFunction<T>(funcName, paramers).AsQueryable();
        }

        /// <summary>
        /// 执行查询类存储过程
        /// </summary>
        /// <param name="funcName"></param>
        /// <param name="paramers"></param>
        /// <returns></returns>
        public virtual DataTable ExecuteFunction(string funcName, params DbParameter[] paramers)
        {
            try
            {
                var conn = (MySql.Data.MySqlClient.MySqlConnection)CoreContext.Database.Connection;
                MySql.Data.MySqlClient.MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = funcName;
                cmd.Parameters.Clear();
                foreach (var paramer in paramers)
                {
                    cmd.Parameters.Add(paramer as MySql.Data.MySqlClient.MySqlParameter);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                
                DataTable dt = new DataTable(); 
                var da = new MySql.Data.MySqlClient.MySqlDataAdapter(selectCommand: cmd);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
