using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Acess_Layer.models;

namespace Data_Acess_Layer.data.repository.interfaces
{
    public interface IGenericReopository<Tentity> where Tentity : BaseEntity
    {
        IEnumerable<Tentity> getall(bool withtracking = false);
        Tentity getbyid(int id);
        int update(Tentity T);
        int delete(Tentity T);
        int add(Tentity T);
    }
}
