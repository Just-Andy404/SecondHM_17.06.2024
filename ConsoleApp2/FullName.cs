﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class FullName
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SurName { get; set; }

        public FullName(string fNme, string lName, string sName)
        {
            FirstName = fNme;
            LastName = lName;
            SurName = sName;
        }

        public override string ToString()
        {
            return $"{LastName} {FirstName} {SurName}";
        }

    }
}
