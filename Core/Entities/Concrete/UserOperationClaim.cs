﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
   public class UserOperationClaim : IEntity
    {
        public int id { get; set; }
        public int userId { get; set; }
        public int operationClaimId { get; set; }   
    }
}
