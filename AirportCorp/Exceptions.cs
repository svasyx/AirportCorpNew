using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportCorp
{

    //класи викоючень
    class minusException : Exception
    {
        public int _value { get; set; }
        public minusException(string message,int value) : base(message)
        {
            _value = value;
        }

        public minusException(string message, Exception InnerException,int value) : base(message, InnerException)
        {
            _value = value;
        }
    }

    class cityException : Exception
    {
        public string _city { get; set; }
        public cityException(string message,string city) : base(message)
        {
            _city = city;
        }

        public cityException(string message, Exception InnerException, string city) : base(message, InnerException)
        {
            _city = city;
        }
    }
    class dateException:Exception
    {
        public DateTime date { get; set; }

        public dateException(string message,DateTime date_):base(message)
        {
            date = date_;

        }
        public dateException(string message, Exception InnerException,DateTime date_):base(message,InnerException)
        {
            date = date_;
        }
    }

    class emptyException:Exception
    {

        public emptyException(string message) : base(message)
        {

        }
        public emptyException(string message, Exception InnerException) : base(message, InnerException)
        {
           
        }

    }
}
