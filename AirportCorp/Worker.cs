using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportCorp
{
    [Serializable]
    class Worker<T>
    {

        protected string _name { get; set; } = "admin";
        protected string _srname { get; set; } = "admin";

            


        protected string _place_of_work { get; set; }

        protected T _id { get; set; }

        protected string _password { get; set; }

        public Worker(string name, string surname, T id,string passw,string place_of_work):base()
        {

            if (String.IsNullOrEmpty(name)||String.IsNullOrEmpty(surname)|| String.IsNullOrEmpty(place_of_work)||String.IsNullOrEmpty(passw))
            {
                throw new emptyException("Строка не може бути порожньою!");
            }

            else
            {
                _name = name;
                _srname = surname;
                _id = id;
                _password = passw;
                _place_of_work = place_of_work;
            }
            

        }

        public Worker():base()
        {
            _name = "Admin";
            _srname = "";
            _password = "admin";
            _place_of_work = "Kiev";
                

        }

        public T Getid()
        {
            return _id;
        }

        public string Getpas()
        {
            return _password;
        }
        public string GetAll()
        {
            return $"{_name} {_srname} {_place_of_work} ";
        }
        
    }
}

