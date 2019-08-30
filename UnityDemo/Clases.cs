using System;


namespace UnityDemo
{
    public class Battery : IBattery
    {
        public Battery()
        {
            Console.WriteLine("Battery ctr");    
        }

        public bool SelfCheck()
        {
            return true;
        }

        public int ChargeRemaining()
        {
            return 70;
        }

        public string Manufacturer()
        {
            return "Wayne Enterprises";
        }

        public string SerialNumber()
        {
            return "123XXGDASJ2345";
        }
    }
    public class Tuner : ITuner
    {
        public string Manufacturer()
        {
            return "Tesla Labs";
        }

        public int TunedFrequency()
        {
            return (int)99.8;
        }

        public bool SelfCheck()
        {
            return true;
        }

        public string SerialNumber()
        {
            return "23423HJSDFGJ234";
        }
    }
    public class Radio : IRadio
    {
        public IBattery Battery { get; set; }
        public ITuner Tuner { get; set; }
        public string Name { get; set; }

        public Radio(IBattery radioBattery, ITuner radioTuner, string radioName)
        {
            Battery = radioBattery;
            Tuner = radioTuner;
            Name = radioName;
        }

        public string RadioName()
        {
            return Name;
        }

        public void Start()
        {
            Console.WriteLine(Name + " sings: Radio Ga Ga");
        }
    }

    public class Dial
    {
        public string TypeOfDial { get; set; }

        public Dial(string typeOfDial)
        {
            TypeOfDial = typeOfDial;
        }

        public string DialType()
        {
            return TypeOfDial;
        }
    }




    public class CheapSpeaker : ISpeaker
    {
        public void Start()
        {
            Console.WriteLine("Sounds cheap");
        }
    }
    public class PriceySpeaker : ISpeaker
    {
        public void Start()
        {
            Console.WriteLine("Sounds Pricey");
        }
    }
}