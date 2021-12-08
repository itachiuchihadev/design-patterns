using System;

namespace CPattern
{
    public class Stereo
    {
        public void On()
        {
            Console.WriteLine("The Light is On.");
        }
        public void Off()
        {
            Console.WriteLine("The Light is Off.");
        }
        public void setCD()
        {
            Console.WriteLine("Stereo is set " +
                               "for CD input");
        }
        public void setDVD()
        {
            Console.WriteLine("Stereo is set" +
                             " for DVD input");
        }
        public void setRadio()
        {
            Console.WriteLine("Stereo is set" +
                               " for Radio");
        }
        public void setVolume(int volume)
        {
            Console.WriteLine("Stereo volume set"
                               + " to " + volume);
        }
    }
}