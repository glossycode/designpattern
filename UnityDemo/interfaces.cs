namespace UnityDemo
{
    public interface IBattery
    {
        bool SelfCheck();

        int ChargeRemaining();

        string Manufacturer();

        string SerialNumber();
    }


    public interface ITuner
    {
        string Manufacturer();

        int TunedFrequency();

        bool SelfCheck();

        string SerialNumber();
    }
    public interface IRadio
    {
        IBattery Battery { get; set; }
        string Name { get; set; }
        ITuner Tuner { get; set; }

        string RadioName();
        void Start();
    }




    public interface ISpeaker
    {
        void Start();
    }

}
