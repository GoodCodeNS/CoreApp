using FirstApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApp
{
    public static class ApplicationContextExtensions
    {
        public static void Seed(this ApplicationContext context)
        {
            if (context.Users.Any())
            {
                return;
            }

            // Roles
            var roles = new List<Role>();
            var role1 = new Role() { RoleId = 1, Name = "admin" };
            var role2 = new Role() { RoleId = 2, Name = "developer" };
            roles.Add(role1);
            roles.Add(role2);

            // Skills
            var skills = new List<Skill>();
            var skill1 = new Skill() { SkillId = 1, Name = ".NET", Description = "Knowledge of .NET" };
            var skill2 = new Skill() { SkillId = 2, Name = "Android", Description = "Knowledge of Android" };
            var skill3 = new Skill() { SkillId = 3, Name = "MS SQL", Description = "Knowledge of MS SQL" };
            

            // Users
            var users = new List<User>();            
            var user1 = new User() { UserId = 1, UserName = "admin1", Password = "pass", RoleId = 1, Role = role1 };
            var user2 = new User() { UserId = 2, UserName = "developer1", Password = "pass", RoleId = 2, Role = role2 };
            

            // UserSkills
            var userSkills = new List<UserSkill>();
            var userSkill1 = new UserSkill() { UserId = 1, User = user1, SkillId = 3, Skill = skill3 };
            var userSkill2 = new UserSkill() { UserId = 2, User = user2, SkillId = 1, Skill = skill1 };
            var userSkill3 = new UserSkill() { UserId = 2, User = user2, SkillId = 2, Skill = skill2 };
            userSkills.Add(userSkill1);
            userSkills.Add(userSkill2);
            userSkills.Add(userSkill3);

            user1.UserSkills.Add(userSkill1);
            user2.UserSkills.Add(userSkill2);
            user2.UserSkills.Add(userSkill3);

            skill1.UserSkills.Add(userSkill2);
            skill2.UserSkills.Add(userSkill3);
            skill3.UserSkills.Add(userSkill1);

            users.Add(user1);
            users.Add(user2);

            skills.Add(skill1);
            skills.Add(skill2);
            skills.Add(skill3);

            context.Users.AddRange(users);
            context.Roles.AddRange(roles);
            context.Skills.AddRange(skills);
            context.UserSkills.AddRange(userSkills);

            context.SaveChanges();
        }
    }
}
