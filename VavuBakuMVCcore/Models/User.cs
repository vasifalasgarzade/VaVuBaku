using System;
using System.ComponentModel.DataAnnotations;

namespace VavuBakuMVCcore.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        [MaxLength(250)]
        public string Photo { get; set; }
        public bool IsActive { get; set; }
        public RoleType Role { get; set; }
    }
}
