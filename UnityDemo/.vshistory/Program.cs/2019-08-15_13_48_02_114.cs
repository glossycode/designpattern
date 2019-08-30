using System;
using Unity;
using Unity.Injection;
using Unity.Resolution;

namespace UnityDemo
{
    public class ContainerMagic
    {
        public static void RegisterElements(IUnityContainer container)
        {
            Dial dial = new Dial("Linear");
            container.RegisterInstance(dial);

            container.RegisterType<IBattery, Battery>();
            container.RegisterType<ITuner, Tuner>();

            container.RegisterType<ISpeaker, CheapSpeaker>("Cheap");
            container.RegisterType<ISpeaker, PriceySpeaker>("Expensive");

            var batteryType = typeof(IBattery);
            var tunerType = typeof(ITuner);
            container.RegisterType<IRadio, Radio>(new InjectionConstructor(batteryType, tunerType, typeof(string)));
        }
    }

    class LogItem
    {
        private static int _counter=-1;
        private int m_Id;

        public int ItemCount { get; set; }
        public LogItem()
        {
            ItemCount = 0;
            lock (this)
            {
                m_Id = ++_counter;
            }
        }

        public override string ToString()
        {
            return string.Format($"{m_Id} with v:{ ItemCount }");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();
            ContainerMagic.RegisterElements(container);
                       
            IBattery battery = container.Resolve<IBattery>();
            Console.WriteLine(battery.SerialNumber());

            Dial dial = container.Resolve<Dial>();
            Console.WriteLine(dial.DialType());

            ITuner tuner = container.Resolve<ITuner>();
            IRadio radio = container.Resolve<IRadio>(new ParameterOverride("radioBattery2", battery),
                new ParameterOverride("radioTuner2", tuner),
                new ParameterOverride("radioName", "BrokenRadio"));
            radio.Start();

            ISpeaker cheapSpeaker = container.Resolve<ISpeaker>("Cheap");
            ISpeaker priceySpeaker = container.Resolve<ISpeaker>("Expensive");
            cheapSpeaker.Start();
            priceySpeaker.Start();
            


            // create a dummy extension for string
            String a = "Je suis une vrai string";
            Console.WriteLine(a + ", et en appelant MySuperExtentionMethod, ça retourne : " +a.MySuperExtentionMethod());
                                   
            // string format with property, of instance variable
            LogItem r = new LogItem() { ItemCount = 455 };
            Console.WriteLine( String.Format($"Write cache dump {r} ({r.ItemCount} items affected)"));
        }
    }
}
