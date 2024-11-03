using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Inheritance_Cunstractor_Method_Base_This
{
    public class Developer
    {

        public string Name;
        public string Surname;
        public double Experience;


        public Developer()
        {
            
        }

        public Developer(string name):this()
        {
            this.Name = name;
        }

        public Developer(string name, string surname):this(name)
        {
            this.Surname = surname;
        }
        public Developer(string name, string surname, double experience):this(name, surname)
        {
           
            this.Experience = experience;
        }
    }
}
