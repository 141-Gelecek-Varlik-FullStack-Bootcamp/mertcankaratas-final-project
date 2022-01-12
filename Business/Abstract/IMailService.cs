using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMailService
    {
        IDataResult<List<Mail>> GetAll();
        IDataResult<Mail> Get(string mail);
        IResult Add(Mail mail);
        IResult Update(Mail mail);
        IResult Delete(Mail mail);
    }
}
