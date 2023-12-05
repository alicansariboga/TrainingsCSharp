﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project13.Entity
{
    public class Employee : Person, IEntity
    {
        public int Salary { get; set; }
        public long ContactPhone { get; set; }
        public string Adress { get; set; }
        public int OffDayMonthly { get; set; }
    }
}
