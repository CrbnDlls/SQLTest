using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLTest.Interfaces
{
    public interface IBaseRepository<T>
    {
        public Task<IEnumerable<T>> GetAll();
        public Task<T> Get(int id);
        public Task<T> Create(T entity);
        public Task<T> Update(T entity);
        public Task<bool> Delete(int id);
        public Task<int> SaveItem(T entity);
    }
}
