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
        protected string _name { get; set; } = "Ivan";
        protected string _surname
        { get; set; } = "Sachno";

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
                _name = name;
                _surname = surname;
            }
        }
        public virtual string GetAll()
        {
            return $"{_name},{_surname} ";
        }
    }
}
