﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSharding.DomainModel.Annotation
{
    public class DomainModelAttribute : Attribute
    {
        public string Name { get; set; }        
    }
}
