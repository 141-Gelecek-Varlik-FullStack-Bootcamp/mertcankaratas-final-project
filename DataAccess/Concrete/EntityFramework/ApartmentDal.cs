using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{

    public class ApartmentDal : EfEntityRepositoryBase<Apartment, ApartmentDBContext>, IApartmentDal
    {
        public List<ApartmentDetailDto> GetApartmentDetails()
        {
            using (ApartmentDBContext context = new ApartmentDBContext())
            {
                var result = from u in context.Users
                             join a in context.Apartments
                             on u.UserId equals a.OwnerId
                             join d in context.Duess
                             on a.DuesId equals d.DuesId
                             from utenant in context.Apartments
                             join ut in context.Users
                             on utenant.TenantId equals ut.UserId
                             select new ApartmentDetailDto
                             {
                                 ApartmentId = a.ApartmentId,
                                 OwnerName = $"{u.Name} {u.LastName}",
                                 TenantName = $"{ut.Name} {ut.LastName}",
                                 BlockNo = a.BlockNo,
                                 FloorNo = a.FloorNo,
                                 DoorNo = a.DoorNo,
                                 ApartmentType = a.ApartmentType,
                                 IsBlank = a.IsBlank,
                                 IsActive = a.IsActive
                               

                             };
                return result.ToList();
                             
            }
        }
    }
}
