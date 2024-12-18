using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Classes
{
    public class Category
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Category(){}

        public Category(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"Category Id : {Id}\nName : {Name}";
        }
    }
}



