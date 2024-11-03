using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Inheritance_Cunstractor_Method_Base_This
{
    public class FrontendDeveloper:Developer
    {

        public FrontendDeveloper(string name,string surname,double experience): base(name, surname, experience)
        {
            
        }
        
        public void ShowFullData()
        {
            Console.WriteLine($"{Name}, {Surname}, {Experience}");
        }
    }
}
