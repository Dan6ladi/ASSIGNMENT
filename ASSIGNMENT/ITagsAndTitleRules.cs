﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT
{
    public interface ITagsAndTitleRules
    {
        public string vehicleColor { get; set; }
        public bool IsdriversLicense { get; set; }
        public bool Istitle { get; set; }
        public bool IsinsuranceInfo { get; set; }
        public bool IssafetyInspection { get; set; }
         
        public string Tayo()
        {
            return "My name is tayo";
        }
    }
}
