using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentOlympiadLib
{
    public class Student : IStudent
    {
        private string name;
        private string lastname;
        private string middlename;
        private int score;
        public string LastName { get => lastname; set => lastname = value; }
        public string Name { get => name; set => name = value; }
        public string MiddleName { get => middlename; set => middlename = value; }
        public string Score { get => Convert.ToString(score); set => score = Convert.ToInt32(value); }
    }
}

