using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Web.Models
{
    public class CertificationResponse
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Code { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public string Cost { get; set; }

        [StringLength(4000)]
        public string Description { get; set; }

        [StringLength(1000)]
        public string Prerequisite { get; set; }

        
    }
}
