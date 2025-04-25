using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Acess_Layer.models
{
    public class BaseEntity
    {
        public int id { get; set; }
        public int createdby { get; set; }
        public DateTime? createdon { get; set; }
        public int lastmodifiedby { get; set; }
        public DateTime? lastmodifiedon { get; set; }
        public bool isdeleted { get; set; }
    }
}
