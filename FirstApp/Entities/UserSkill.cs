using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApp.Entities
{
    public class UserSkill
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int SkillId { get; set; }
        public Skill Skill { get; set; }
    }
}
