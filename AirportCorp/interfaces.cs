using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportCorp
{

    //інтерфейс для друку та його наслідування
    interface IPrintable
    {
        string GetAll();
    }
    interface ITraveler:IPrintable
    {
        
    }
    interface IBusinesmann : IPrintable
    {

    }
}
