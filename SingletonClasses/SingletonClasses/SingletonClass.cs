using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonClasses
{
    public class SingletonClass
    {
        public int num1 { get; set; }
        public int num2 { get; set; }
        private SingletonClass() { }

        private static SingletonClass _instance = null;
        public static SingletonClass Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new SingletonClass();
                }

                return _instance;
            } 
        }

        public void Sum()
        {
            Console.WriteLine(num1 + num2);
        }
    }
}
