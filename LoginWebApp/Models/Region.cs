﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoginWebApp.Models
{
    public class Region
    {
        [Key]
        public int Id { get; set; }

        public int CityCode { get; set; }

        public string RegionName { get; set; }
    }
}
