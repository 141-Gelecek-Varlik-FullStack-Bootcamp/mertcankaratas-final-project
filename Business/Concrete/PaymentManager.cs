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
        public PaymentManager(IPaymentDal paymentDal)
        {
            _paymentDal = paymentDal;
        }
        [ValidationAspect(typeof(InvoiceTypeValidator))]
        public IResult Add(Payment payment)
        {
            payment.IDate = DateTime.Now;
            _paymentDal.Add(payment);
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
