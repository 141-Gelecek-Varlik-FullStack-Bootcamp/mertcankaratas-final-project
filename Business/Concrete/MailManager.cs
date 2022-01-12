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
    public class MailManager : IMailService
    {
        IMailDal _mailDal;

        public MailManager(IMailDal mailDal)
        {
            _mailDal = mailDal;
        }

        public IResult Add(Mail mail)
        {
            _mailDal.Add(mail);
            return new SuccessResult(Messages.MailSend);
        }

        public IResult Delete(Mail mail)
        {
            mail.IsDelete = true;
            _mailDal.Update(mail);

            return new SuccessResult(Messages.MailDelete);
        }

        public IDataResult<Mail> Get(string mail)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Mail>> GetAll()
        {
            return new SuccessDataResult<List<Mail>>(_mailDal.GetAll(), Messages.MailList);
        }

        public IResult Update(Mail mail)
        {
            mail.IsNew = false;
            mail.IsRead = true;
            _mailDal.Update(mail);

            return new SuccessResult(Messages.MailUpdate);
        }
    }
}
