using System;

namespace IronNinja2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            SweetTooth sweet = new SweetTooth();
            SpiceHound spicy = new SpiceHound();
            Buffet AYCE = new Buffet();
            while(spicy.IsFull ==false)
            {
                spicy.Consume(AYCE.ServeFood());
            }
            while(sweet.IsFull == false)
            {
                sweet.Consume(AYCE.ServeDrink());
            }
            spicy.ConsumeHist();
            sweet.ConsumeHist();
        }
    }
}
