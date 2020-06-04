using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Parking.Domain.Core.Entities
{
    public class TowerBlock
    {
        [Key]
        public int TowerBlockId { get; set; }

        public string BlockDescription { get; set; }
    }
}