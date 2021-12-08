namespace CPattern
{
    public class LightOffCommand : ICommand
    {
        public Light _light;
        public LightOffCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.Off();
        }
    }
}