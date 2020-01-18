using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        private static void Main(string[] args)
        {
            var john = new Humanoid(new Dancing());
            Console.WriteLine(john.ShowSkill()); //print dancing
            var alex = new Humanoid(new Cooking());
            Console.WriteLine(alex.ShowSkill());//print cooking
            var bob = new Humanoid();
            Console.WriteLine(bob.ShowSkill());//print no skill is defined

            Console.ReadLine();
        }
    }
    
    class Humanoid 
    { 
          IHobbies hobbies = null; 
          public Humanoid() 
          { 
              hobbies = null; 
          } 
          public Humanoid(IHobbies hobby) 
          { 
              hobbies = hobby;           
          } 
          public string ShowSkill() 
          { 
              if (hobbies == null) 
                  return "no skill is defined"; 
              else 
                  return hobbies.ShowSkill(); 
          }
    }
    interface IHobbies 
    { 
        string ShowSkill(); 
    }
    class Dancing: IHobbies 
    { 
        public string ShowSkill() 
        { 
            return "Dancing"; 
        } 
    }
    class Cooking: IHobbies 
    { 
        public string ShowSkill() 
        { 
            return "Cooking"; 
        } 
    }
}
