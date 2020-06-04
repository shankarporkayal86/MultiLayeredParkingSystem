using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parking.Domain.Core.Entities
{
    public class Tower
    {
        [Key]
        public int TowerId { get; set; }

        public string TowerDescription { get; set; }
    }
}