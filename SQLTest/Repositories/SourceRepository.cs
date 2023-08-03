using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SQLTest.Interfaces;
using SQLTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLTest.Repositories
{
    internal class SourceRepository : ISourceRepository
    {
        public async Task<Source> Create(Source entity)
        {
            using (var db = new MyDataBaseContext())
            {
                EntityEntry<Source> entityEntry = await db.Sources.AddAsync(entity);

                db.SaveChanges();

                return entityEntry.Entity;
            }
        }

        public async Task<bool> Delete(int id)
        {
            using (var db = new MyDataBaseContext())
            {
                Source source = await Get(id);
                if (source != null)
                {
                    db.Sources.Remove(source);

                    db.SaveChanges();

                    return true;
                }
                return false;
            }
        }

        public async Task<Source> Get(int id)
        {
            using (var db = new MyDataBaseContext())
            {
                return await db.Sources.FindAsync(id);
            }
        }

        public async Task<IEnumerable<Source>> GetAll()
        {
            using (var db = new MyDataBaseContext())
            {
                return await Task.Run(() => db.Sources.Include(x => x.Emissions).AsEnumerable().ToList());
            }
        }

        public async Task<int> SaveItem(Source entity)
        {
            if (entity.IdSource == 0)
            {
                return (await Create(entity)).IdSource;
            }
            else
            {
                return (await Update(entity)).IdSource;
            }
            
        }

        public async Task<Source> Update(Source entity)
        {
            using (var db = new MyDataBaseContext())
            {
                EntityEntry<Source> entityEntry = await Task.Run(() => db.Sources.Update(entity));

                db.SaveChanges();

                return entityEntry.Entity;
            }
        }
    }
}
