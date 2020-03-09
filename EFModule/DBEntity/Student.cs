using EFModule.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFModule.DBEntity
{
    public class Student
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public GenderType Gender { get; set; }
        public int Age { get; set; }
        public DateTime BirthDay { get; set; }
    }
}
