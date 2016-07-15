﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Fr.Repositories
{
    public class EfContext: DbContext
    {
        public EfContext(string ConnectionString)
            : base(ConnectionString)
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<EfContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var entityConfigs = Assembly.GetExecutingAssembly().GetTypes()
                               .Where(thistype =>
                               {
                                   Type parent = thistype.BaseType;
                                   if (thistype.BaseType == null)
                                       return false;
                                   if (!parent.IsGenericType)
                                       return false;
                                   if (parent.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>))
                                   {
                                       return true;
                                   } 
                                   return false;
                               });
            foreach (Type config in entityConfigs)
            {
                var constructor = config.GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance, null, new Type[0], null);
                if (constructor == null)
                    throw new Exception(string.Format("请将类型（{0}）的构造函数声明为internal或private", config.Name));
                var entityConfigObj = constructor.Invoke(null);
                AddtoConfig(entityConfigObj, modelBuilder);
            }
        }

        private void AddtoConfig(object config, DbModelBuilder modelBuilder)
        {
            var addMethod = modelBuilder.Configurations
                            .GetType()
                            .GetMethods()
                            .FirstOrDefault
                            (
                                x => x.Name == "Add" &&
                                x.GetParameters().First().ParameterType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>)
                            );
            var generic = config.GetType().BaseType.GetGenericArguments().First();
            addMethod = addMethod.MakeGenericMethod(generic);
            addMethod.Invoke(modelBuilder.Configurations, new object[] { config });
        }
    }
}
