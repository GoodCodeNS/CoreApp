using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApp.Entities
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MaxLength(50)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(100)]
        public string Password { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }

        public ICollection<UserSkill> UserSkills { get; set; } = new HashSet<UserSkill>();
    }
}
