using Business.Abstract;
using Business.Constant;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
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
    public class PaymentManager : IPaymentService
    {
        IPaymentDal _paymentDal;
        IApartmentService _apartmentService;
        public PaymentManager(IPaymentDal paymentDal,IApartmentService apartmentService)
        {
            _paymentDal = paymentDal;
            _apartmentService = apartmentService;
        }
       
        //[ValidationAspect(typeof(InvoiceTypeValidator))]
        public IResult Add(Payment payment)
        {
            payment.IDate = DateTime.Now;
            payment.BillingDate = DateTime.Now;
            payment.DueDate = DateTime.Now.AddDays(10);
            _paymentDal.Add(payment);
            return new SuccessResult(Messages.PaymentAdded);
        }

        public IResult MultipleAdd(string blockNo,decimal paymentAmount,int InvoiceId)
        {
            decimal perApartment = paymentAmount / _apartmentService.GetAllByBlockName(blockNo).Data.Count();
            
            List<Apartment> result = _apartmentService.GetAllByBlockName(blockNo).Data;
            foreach (var item in result)
            {
                if(item.TenantId != null)
                {
                    var payment = new Payment
                    {
                        UserId = (int)item.TenantId,
                        ApartmentId = item.ApartmentId,
                        InvoiceId = InvoiceId,
                        Amount = perApartment
                    };

                    Add(payment);
                }
                else
                {
                    var payment = new Payment
                    {
                        UserId = item.OwnerId,
                        ApartmentId = item.ApartmentId,
                        InvoiceId = InvoiceId,
                        Amount = perApartment
                    };
                    Add(payment);
                }
            }
           

            return new SuccessResult(Messages.PaymentAdded);
        }
    




        public IResult Delete(Payment payment)
        {
            payment.UDate = DateTime.Now;
            _paymentDal.Delete(payment);
            return new SuccessResult(Messages.PaymentDeleted);

        }

        public IDataResult<Payment> Get(int id)
        {
            return new SuccessDataResult<Payment>(_paymentDal.Get(u => u.PaymentId == id));
        }

        public IDataResult<List<Payment>> GetAll()
        {
            return new SuccessDataResult<List<Payment>>(_paymentDal.GetAll(),Messages.PaymentListed);
        }

        public IResult Update(Payment payment)
        {
            payment.UDate = DateTime.Now;
            _paymentDal.Update(payment);
            return new SuccessResult(Messages.PaymentDeleted);
        }
    }
}
