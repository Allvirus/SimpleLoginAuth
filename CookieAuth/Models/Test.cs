using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CookieAuth.Models
{
    public class Test
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "某人")]
        public string Someone { get; set; }
        [Required]
        [Display(Name = "某事")]
        public string Something { get; set; }

    }
}
