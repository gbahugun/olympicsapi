﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympicsWeb.Models
{
    public class Country
    {
        public int CountryId { get; set; }
        public int Rank { get; set; }
        public string Name { get; set; }
        public int Gold { get; set; }
        public int Silver { get; set; }
        public int Bronze { get; set; }
        public int Total { get; set; }
    }
}
