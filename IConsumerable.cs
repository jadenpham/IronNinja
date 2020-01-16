using System;
using System.Collections.Generic;

namespace IronNinja2
{
    interface IConsumerable
    {
        string Name {get; set;}
        int Calories {get; set;}
        bool Spicy {get; set;}
        bool Sweet {get; set;}
        string GetInfo();
    }
}