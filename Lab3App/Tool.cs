﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Tool : Collectable
    {
        public virtual void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            DoAction();
     
        }
        public virtual void DoAction()
        {

        }
    }
}
