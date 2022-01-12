using Business.Abstract;
using Business.Constant;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CreditCardManager : ICreditCardService
    {
        private readonly IMongoCollection<CreditCard> _creditCard;

        public CreditCardManager(IDbClient creditCard)
        {
            _creditCard = creditCard.GetCreditCardCollection();
        }

        public IResult AddCreditCard(CreditCard creditCard)
        {
            _creditCard.InsertOne(creditCard);
            return new SuccessResult (Messages.PaymentSuccess);
        }

        public IDataResult<List<CreditCard>> GetCreditCards()
        {
            throw new NotImplementedException();
        }
    }
}
