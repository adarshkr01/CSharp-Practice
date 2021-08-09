using System;
using System.Collections.Generic;

namespace ClassesPractice
{
    class Customer
    {
        public int Id;
        public string Name;
        public List<Order> orders;

        public Customer() 
        {
            orders = new List<Order>();
        }

        public Customer(int id)
            : this() // calls the default contructor first
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id) // calls the constructor with Id as parameter (which in turn calls the default constructor)
        {
            this.Name = name;
        }
    }
}
