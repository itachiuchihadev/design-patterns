using System;

namespace CPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Commnad object is Created
            Light light = new Light();
            Stereo stereo = new Stereo();

            //Commands are Created
            LightOnCommand lightOnCommand = new LightOnCommand(light);
            LightOffCommand lightOffCommand = new LightOffCommand(light);
            StereoCommand stereoCommand = new StereoCommand(stereo);
            StereoWithCDCommand stereoWithCDCommand = new StereoWithCDCommand(stereo);

            //Setting the Command
            SimpleRemote remote = new SimpleRemote();
            remote.SetCommand(stereoWithCDCommand);

            //Pressing the Button
            remote.ButtonPressed();

        }
    }
}
