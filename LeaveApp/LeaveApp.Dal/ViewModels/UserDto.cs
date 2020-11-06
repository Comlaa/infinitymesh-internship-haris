using LeaveApp.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeaveApp.Dal.ViewModels
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }
        public string Password { get; set; }
        public UserDto() { }
        public UserDto(User User)
        {
            Id = User.Id;
            Name = User.Name;
            Email = User.Email;
            Department = User.Department;
            JobTitle = User.JobTitle;
            Password = User.Password;
        }

    }
}
