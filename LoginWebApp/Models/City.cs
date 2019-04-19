using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoginWebApp.Models
{
    public class City
    {
        public City()
        {

        }

        [Key]
        public int CityCode { get; set; }

        public string Name { get; set; }
    }
}
