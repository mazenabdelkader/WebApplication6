using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Acess_Layer.data.repository.interfaces;
using Data_Acess_Layer.models;
using Microsoft.EntityFrameworkCore;

namespace Data_Acess_Layer.data.repository.classes
{
    public class GenericRepository<Tentity>(AppDBContext appContext) : IGenericReopository<Tentity> where Tentity : BaseEntity
    {


        public int add(Tentity tentity)
        {
            appContext.Set<Tentity>().Add(tentity);
            return appContext.SaveChanges();
        }
        public int delete(Tentity tentity)
        {
            appContext.Set<Tentity>().Remove(tentity);
            return appContext.SaveChanges();
        }
        public IEnumerable<Tentity> getall(bool withtracking = false)
        {
            if (withtracking)
                return appContext.Set<Tentity>().ToList();
            else
                return appContext.Set<Tentity>().AsNoTracking().ToList();   
        }
        public Tentity getbyid(int id)
        {
            return appContext.Set<Tentity>().Find(id);
        }
        public int update(Tentity tentity)
        {
            appContext.Set<Tentity>().Update(tentity);
            return appContext.SaveChanges();
        }
    }
}