﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class MagicWand : Tool
    {
        public void Display()
        {
            Console.WriteLine("Magic Wand " + Description + " is displayed");
        }
        public void DoAction() 
        {
            Console.WriteLine("MagicWand is Used");
        }
    }
}
