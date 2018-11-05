using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApp.Entities
{
    public class Skill
    {
        [Key]
        public int SkillId { get; set; }

        [Required]
        [MaxLength(50)]        
        public string Name { get; set; }

        [MaxLength(200)]        
        public string Description { get; set; }

        public ICollection<UserSkill> UserSkills { get; set; } = new HashSet<UserSkill>();
    }
}
