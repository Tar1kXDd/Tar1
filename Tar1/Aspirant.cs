using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tar1
{
    public class Aspirant : Student
    {
        public string ScientificWork;
        public Aspirant(string name, string lastName, string grupp, int averageMark, string scientificWork) 
            : base(name, lastName, grupp, averageMark)
        {
            ScientificWork = scientificWork;
        }
        public override int getScolarship()
        {
            if (AverageMark == 5) return 200;
            else
                return 180;

        }
    }
}
