using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Apartment:IEntity
    {
        public int ApartmentId { get; set; }
        public int DuesId { get; set; }
        public int OwnerId{ get; set; }
        public int? TenantId{ get; set; }
        public string ResidentType { get; set; }
        public string BlockNo { get; set; }
        public string FloorNo { get; set; }
        public string DoorNo { get; set; }
        public string ApartmentType{ get; set; }
        public bool IsBlank { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public int  IUser { get; set; }
        public int?  UUser { get; set; }
        public DateTime IDate { get; set; }
        public DateTime? UDate { get; set; }




    }
}
