using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace AirportCorp
{
    [Serializable]
    public class Traveller : Person,IPrintable, ITraveler, IComparable<Traveller>
    {
        protected string from_ { get; set; } = "home";
        protected string to_ { get; set; } = "home";
        protected int time_of_travel_ { get; set; } = 0;
        protected bool laggage_ = false;
        protected bool visa_ = false;
        protected double visa_price;
        protected int _distance;
        protected double _cost_of_travel;
        protected int _price_of_travel = 130;
        protected int from_e;
        protected int to_e;

        protected DateTime _arr { get; set; } = DateTime.Now;
        protected DateTime _dep { get; set; } = DateTime.Now;


        public delegate double Price(double distance, double price_of_travel,double visa_price);
        public event Price PriceHandler;

        Airport_company airport_Company = new Airport_company();
 
        public Traveller() : base()
        {
            
        }

        public int CompareTo(Traveller tr)
        {
            return time_of_travel_.CompareTo(tr.time_of_travel_);
        }


        public Traveller(string name, string surname, string from, string to,int time_of_travel, bool laggage, bool visa, DateTime arr, DateTime dep) : base(name, surname)
        {


            if (dep.Day - arr.Day  < 0  || dep.Month - arr.Month < 0 && arr.Year == DateTime.Today.Year) 
            {
                throw new dateException("Виберіть правильну дату!!!", arr);
            }

            _arr = arr;
            _dep = dep;
            if (time_of_travel < 0)
            {
                
                throw new minusException("Не може бути менше за нуль!",time_of_travel);
            }
            else
            {
                time_of_travel_ = time_of_travel;
            }

            if (from == to)
            {
                throw new cityException("Міста не можуть бути однаковими", from);
            }
                else {
                        from_ = from;
                        to_ = to;
                    }
            
            laggage_ = laggage;
            visa_ = visa;
            name_ = name;

            if (visa == true)
            {
                visa_price = 0;

            }

            else
            {
                visa_price = 130 * time_of_travel_;
            }
           
           foreach(KeyValuePair<string,int> key in airport_Company.Getairports())
            {
                if(key.Key == from_)
                {
                    from_e = key.Value;
                }
                if(key.Key == to_)
                {
                    to_e = key.Value;

                }
            }
            _distance = from_e + to_e;
            try
            {

            }
            catch(Exception exp)
            {
                Console.WriteLine(exp.Message);
            }

            PriceHandler += Price1;


            }



        public override string GetAll()
        {
            return base.GetAll() + $"{from_} - {to_},  {time_of_travel_} днів, Ціна за квиток: {GetPrice()}";
        }

         public double GetPrice()
        {
            if (laggage_)
            {
                _cost_of_travel = (double)PriceHandler?.Invoke(_distance, _price_of_travel * 1.005, visa_price);
            }
            else
            {
                _cost_of_travel = (double)PriceHandler?.Invoke(_distance, _price_of_travel, visa_price);
            }
            return _cost_of_travel;
        }

        public double Price1(double distance, double price_of_travel, double visa_price)
        {
            return distance * price_of_travel + visa_price;
        }

    }
}
