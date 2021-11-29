using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[]args)
        {
            MyDictionary<int,string> myDictionary=new MyDictionary<int,string>();
            myDictionary.Add(5600,"Kaan");
            myDictionary.Add(2800, "Salih");
            Console.WriteLine("Ankara");
  
        }
    }



}    