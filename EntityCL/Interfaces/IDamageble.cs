﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCL.Interfaces
{
    public interface IDamageble
    {
        public void TakeDamageFrom(EntityAC Entity);
    }
}
