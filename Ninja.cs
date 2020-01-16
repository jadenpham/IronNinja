using System;
using System.Collections.Generic;

namespace IronNinja2
{
    abstract class Ninja
    {
        protected int calIntake;
        public List<IConsumerable> ConsumedList;
        public Ninja()
        {
            calIntake = 0;
            ConsumedList = new List<IConsumerable>();
        }
        public abstract bool IsFull {get;}
        public abstract void Consume(IConsumerable item);
    }

    class SweetTooth : Ninja
    {
        public override bool IsFull 
        {
            get 
            {
                if(calIntake <1500) {return false;}
                else{return true;}
            }
        }
        public override void Consume(IConsumerable item)
        {
            if(IsFull)
            {
                System.Console.WriteLine("Character is full, can't consume anymore");
            }
            else
            {
                if(item.Sweet == true)
                {
                    calIntake += item.Calories +10;
                }
                else{
                    calIntake += item.Calories;
                }
                ConsumedList.Add(item);
                item.GetInfo();
            }
        }
        public void ConsumeHist()
        {
            foreach(var item in ConsumedList)
            {
                System.Console.WriteLine(item.Name);
            }
        }
    }
    class SpiceHound : Ninja
    {
        public override bool IsFull
        {
            get 
            {
                if(calIntake <1200) {return false;}
                else{return true;}
            }
        }
        public override void Consume(IConsumerable item)
        {
            if(IsFull)
            {
                System.Console.WriteLine("Character is full, can't consume anymore");
            }
            else
            {
                if(item.Spicy == true)
                {
                    calIntake += item.Calories - 5;
                }
                calIntake += item.Calories;
                ConsumedList.Add(item);
                item.GetInfo();
            }
        }
        public void ConsumeHist()
        {
            foreach(var food in ConsumedList)
            {
                System.Console.WriteLine(food.Name);
            }
        }
    }
}