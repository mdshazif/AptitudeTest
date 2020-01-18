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
            var myHouse = new Building()
                .AddKitchen()
                .AddBedroom("master")
                .AddBedroom("guest")
                .AddBalcony();
            var normalHouse = myHouse.Build();
            //kitchen, master room, guest room, balcony
            Console.WriteLine(normalHouse.Describe());
            myHouse.AddKitchen().AddBedroom("another");
            var luxuryHouse = myHouse.Build();
            //it only shows the kitchen after build
            //kitchen, master room, guest room, balcony, kitchen, another room
            Console.WriteLine(luxuryHouse.Describe());

            Console.ReadLine();
        }
    }

    public class Building
    {
        private NormalHouse obj = new NormalHouse();
        public Building AddKitchen() { obj.AddKitchen(); return this; }
        public Building AddBedroom(string name) { obj.AddBedroom(name); return this; }
        public Building AddBalcony() { obj.AddBalcony(); return this; }
        public NormalHouse Build() { return obj; }
    }
    public class NormalHouse
    {
        public string Description = string.Empty;
        public void AddKitchen()
        {
            Description = string.Join(",", Description, "kitchen");
        }
        public void AddBedroom(string name) { Description = string.Join(",", Description, name + " room"); }
        public void AddBalcony() { Description = string.Join(",", Description, "balcony"); }
        public string Describe() { return Description.Trim(",".ToCharArray()); }
    }

}
