namespace CPattern
{
    public class LightOnCommand : ICommand
    {
        public Light _light;
        public LightOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.On();
        }
    }
}