using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon_s_Project
{

    class Employee
    {
        public override string ToString()
        {
            return "This Employee is called: "+name+"\nTheir ID is: "+id+ "\nTheir gender is: "+gender;
        }
        public string name;
        public int id;
        public Gender gender;

    }
    public enum Gender
    {
        M,
        F,
        X,
    }
}
