using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Vs_Var
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> myList = new List<object>();
            myList.Add(1);
            myList.Add("We are all greatful to Sir Dennis Ritchie");
            myList.Add(true);
            myList.Add(120.40);

            foreach (var v in myList)
            Console.WriteLine(v);
            Console.ReadLine();
        }
    }
}
