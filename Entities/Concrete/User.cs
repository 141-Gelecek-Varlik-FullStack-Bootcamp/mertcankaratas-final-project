﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class User:IEntity
    {
        public int UserId { get; set; }
        public string IdentityNo { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string? Plaka { get; set; }
        public string Type { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public int IUser { get; set; }
        public int? UUser { get; set; }
        public DateTime IDate { get; set; }
        public DateTime? UDate { get; set; }


    }
}
