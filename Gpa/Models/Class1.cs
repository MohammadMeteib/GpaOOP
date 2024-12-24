using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gpa.Models
{
    public class Student
    {
        public string StudentInfo(string name, string major, int gpa)
        {
            return "Student name is: " + name + ". Major is: " + major + ". GPA is: " + gpa;
        }
    }
}
