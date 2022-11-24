using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tar1
{
    public class Student
    {
        public string Name;
        public string LastName;
        public string Grupp;
        public int AverageMark;

        public Student (string name, string lastName, string grupp, int averageMark)
        {
            Name = name;
            LastName = lastName;
            Grupp = grupp;
            AverageMark = averageMark;
        }
        public virtual int getScolarship()
        {
            if (AverageMark == 5) return 100;
            else
                return 80;

        }

    }
}
