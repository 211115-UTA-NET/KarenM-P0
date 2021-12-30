using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopApp.Logic;

namespace CoffeeShopApp.DataInfrastructure
{
    //using generic means I just need one repository for all my classes instead of induvual
    public interface IRepository<T> where T : class
    {
        //should get Classes made
        IEnumerable<T> GetAll();
        IEnumerable<T> FindAll();

        //User Find(long id);
        T Get(int id);
        void Add(T entity);
        void Inster(T entity);
        void Update(T entity);
        void Delete(T entity);
        void save(T entity);


    }
}
