using Business.Abstract;
using Business.Constant;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ApartmentManager : IApartmentService
    {
        IApartmentDal _apartmentDal;

        public ApartmentManager(IApartmentDal apartmentDal)
        {
            _apartmentDal = apartmentDal;
        }
        public IResult Add(Apartment apartment)
        {
            _apartmentDal.Add(apartment);
            return new SuccessResult(Messages.ApartmentAdded);
        }

        public IResult Delete(Apartment apartment)
        {
            _apartmentDal.Delete(apartment);
            return new SuccessResult(Messages.ApartmentDeleted);
        }

        public IDataResult<Apartment> Get(int id)
        {
            return new SuccessDataResult<Apartment>(_apartmentDal.Get(a => a.ApartmentId == id));
        }

        public IDataResult<List<Apartment>> GetAll()
        {
            return new SuccessDataResult<List<Apartment>>(_apartmentDal.GetAll(), Messages.ApartmentListed);
        }

        public IResult Update(Apartment apartment)
        {
            _apartmentDal.Update(apartment);
            return new SuccessResult(Messages.ApartmentUpdated);
        }
    }
}
