using System;
using System.Runtime.CompilerServices;
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
            IRadio radio = container.Resolve<IRadio>(new ParameterOverride("radioBattery", battery),
                new ParameterOverride("radioTuner", tuner),
                new ParameterOverride("radioName", "BrokenRadio"));
            radio.Start();

            ISpeaker cheapSpeaker = container.Resolve<ISpeaker>("Cheap");
            ISpeaker priceySpeaker = container.Resolve<ISpeaker>("Expensive");
            cheapSpeaker.Start();
            priceySpeaker.Start();



            String a = "Je suis une vrai string";
            
            Console.WriteLine(a + ", et en appelant MySuperExtentionMethod, ça retourne : " +a.MySuperExtentionMethod());
        }
    }
}
