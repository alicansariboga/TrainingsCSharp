﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project14.Entities
{
    public class Region : IEntity
    {
        public int RegionId { get; set; }
        public string RegionDescription { get; set; }
    }
}
