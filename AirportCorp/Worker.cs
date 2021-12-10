using System;
using System.Collections.Generic;
namespace AirportCorp
{
    [Serializable]
    class Worker<T> where T: Airport
    {


        protected T _place_of_work { get; set; }

        protected string _name { get; set; }
        protected string _surname { get; set; }
        protected string _id { get; set; }


        protected string _password { get; set; }


        public Worker(string name, string surname, string id, string passw, T place_of_work) 
        {

            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(surname) || String.IsNullOrEmpty(id) || String.IsNullOrEmpty(passw))
            {
                throw new emptyException("Строка не може бути порожньою!");
            }

            else
            {
                _name = name;
                _surname = surname;
                _place_of_work = place_of_work;
                
                _id = id;
                _password = passw;
                _id = id;
            }


        }

        public Worker()
        {
            _name = "name";
            _surname = "surname";
            _password = "admin";
         
        }

        
        public T GetPlaceOfWork()
        {
            return _place_of_work; 
        }
        

        public string Getid()
        {
            return _id;
        }

        public string Getpas()
        {
            return _password;
        }
        public  string GetAll()
        {
            return  $"{_name} {_surname} {_place_of_work.GetAll()} ";
        }

    }
}

