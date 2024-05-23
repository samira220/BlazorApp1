using System;
using System.Data;

namespace BlazorApp1
{
    public class Students
    {
        public Students(int id, string name, string surName, string lastName, string group, string photo, DateTime dateOfBirth)
        {
            Id = id;
            Name = name;
            SurName = surName;
            LastName = lastName;
            Group = group;
            Photo = photo;
            DateOfBirth = dateOfBirth;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set;}
        public string LastName { get; set; }
        public string Group { get; set; }
        public string Photo { get; set; }
        public  DateTime DateOfBirth { get; set; }

    }
}
