using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportCorp
{
    [Serializable]
    public class Person : IPrintable
    {
        protected string name_ { get; set; } = "Ivan";
        protected string surname_ { get; set; } = "Sachno";

        public Person()
        {

        }

        public Person(string name, string surname)
        {
            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(surname))
            {
                throw new emptyException("Строка не може бути порожньою!");
            }
            else
            {
                name_ = name;
                surname_ = surname;
            }
        }
        public virtual string GetAll()
        {
            return $"{name_},{surname_} ";
        }
    }
}
