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
    internal class EmissionRepository : IEmissionRepository
    {
        public async Task<Emission> Create(Emission entity)
        {
            using (var db = new MyDataBaseContext())
            {
                EntityEntry<Emission> entityEntry = await db.Emissions.AddAsync(entity);

                db.SaveChanges();

                return entityEntry.Entity;
            }
        }

        public async Task<bool> Delete(int id)
        {
            using (var db = new MyDataBaseContext())
            {
                Emission emission = await Get(id);
                if (emission != null)
                {
                    db.Emissions.Remove(emission);

                    db.SaveChanges();

                    return true;
                }
                return false;
            }
        }

        public async Task<Emission> Get(int id)
        {
            using (var db = new MyDataBaseContext())
            {
                return await db.Emissions.FindAsync(id);
            }
        }

        public async Task<IEnumerable<Emission>> GetAll()
        {
            using (var db = new MyDataBaseContext())
            {
                return await Task.Run(() => db.Emissions.Include(x=>x.IdSourceNavigation).AsEnumerable().ToList());
            }
        }

        public async Task<int> SaveItem(Emission entity)
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

        public async Task<Emission> Update(Emission entity)
        {
            using (var db = new MyDataBaseContext())
            {
                EntityEntry<Emission> entityEntry = await Task.Run(() => db.Emissions.Update(entity));

                db.SaveChanges();

                return entityEntry.Entity;
            }
        }

        internal async Task<IEnumerable<Source>> GetSources()
        {
            SourceRepository sourceRepository = new SourceRepository();
            return await sourceRepository.GetAll();
        }
    }
}
