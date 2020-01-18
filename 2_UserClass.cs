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
            while (true)
            {
                var user = new User();
                Console.WriteLine("Please enter the username, or q to exit");
                var username = Console.ReadLine();
                if (username == "q")
                {
                    break;
                }
                user.Add(UserName);
                Console.WriteLine($"number of addedUser {user.GetUsersCount()}");
            }
            Console.ReadLine();
        }
    }
    
    public class User 
    { 
        private static List<string> inputUser = new List<string>(); 
        public void Add(string UserName) 
        { 
            inputUser.Add(UserName); 
        } 
        public int GetUsersCount() 
        { 
            return inputUser.Count(); 
        } 
    }
}
