using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class InvoiceType : IEntity
    {
        public int InvoiceTypeId { get; set; }
        public string InvoiceName { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public int IUser { get; set; }
        public int? UUser { get; set; }
        public DateTime IDate { get; set; }
        public DateTime? UDate { get; set; }
    }
}
