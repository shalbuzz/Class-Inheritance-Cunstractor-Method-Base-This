using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Inheritance_Cunstractor_Method_Base_This
{
    public class BackendDeveloper :Developer{

        public BackendDeveloper():base()
        {
            
        }
        public BackendDeveloper(string name):base(name) 
        {
            
        }

        public BackendDeveloper(string name, string surname):base(name,surname)
        {
            
        }
        public BackendDeveloper(string name, string surname, double experience) : base(name, surname, experience)
        {

        }
        public BackendDeveloper(string name, string surname, double experience, double sqlExperience):this(name,surname, experience) 
        {
            
        }


        public double SqlExperience;
    }

}