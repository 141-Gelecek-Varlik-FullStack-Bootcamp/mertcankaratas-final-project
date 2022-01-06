﻿using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<UserDal>().As<IUserDal>().SingleInstance();
            builder.RegisterType<PaymentManager>().As<IPaymentService>().SingleInstance();
            builder.RegisterType<PaymentDal>().As<IPaymentDal>().SingleInstance();
            builder.RegisterType<InvoiceTypeManager>().As<IInvoiceTypeService>().SingleInstance();
            builder.RegisterType<InvoiceTypeDal>().As<IInvoiceTypeDal>().SingleInstance();
            builder.RegisterType<ApartmentManager>().As<IApartmentService>().SingleInstance();
            builder.RegisterType<ApartmentDal>().As<IApartmentDal>().SingleInstance();
            builder.RegisterType<DuesManager>().As<IDuesService>().SingleInstance();
            builder.RegisterType<DuesDal>().As<IDuesDal>().SingleInstance();
            builder.RegisterType<AuthManager>().As<IAuthService>().SingleInstance();
            

        }
    }
}