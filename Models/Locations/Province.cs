using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabCodeFirst.Models.Locations
{
    public class Province
    {
        [Key]
        [Display(Name = "Province Code")]
        public int ProvinceCode { get; set; }

        [Display(Name = "Province")]
        public string ProvinceName { get; set; }


        public List<City> Cities { get; set; }

    }
}