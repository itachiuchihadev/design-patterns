namespace CPattern
{
    public class StereoWithCDCommand : ICommand
    {
        public Stereo _stereo;
        public StereoWithCDCommand(Stereo stereo)
        {
            _stereo = stereo;
        }
        public void Execute()
        {
            _stereo.On();
            _stereo.setCD();
            _stereo.setVolume(4);
        }
    }
}