namespace CPattern
{
    public class StereoCommand : ICommand
    {
        public Stereo _stereo;
        public StereoCommand(Stereo stereo)
        {
            _stereo = stereo;
        }
        public void Execute()
        {
            _stereo.On();
        }
    }
}