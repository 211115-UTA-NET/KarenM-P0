using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopApp.DataInfrastructure
{
    public class Repository<T> : IRepository<T> where T : class
    {

        //Database context
        protected readonly CoffeeShopAppDbContext context; //still havent added a dbcontext

        //Constructor
        public Repository(CoffeeShopAppContext context)
        {
            this.context = context;
        }
        void IRepository<T>.Add(T entity)
        {
            context.Set<T>.Add(entity);
        }

        void IRepository<T>.Delete(T entity)
        {
            context.Set<T>.Delete(entity);
        }

        IEnumerable<T> IRepository<T>.FindAll()
        {
            return context.Set<T>;
        }

        T IRepository<T>.Get(int id)
        {
            return context.Set<T>().Find(id);
        }

        IEnumerable<T> IRepository<T>.GetAll()
        {
            return context.Set<T>();
        }

        void IRepository<T>.Inster(T entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<T>.save(T entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<T>.Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
