using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApp.Entities
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
