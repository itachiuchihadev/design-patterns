namespace CPattern
{
    public class SimpleRemote
    {
        public ICommand _command;
        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void ButtonPressed(){
            if(_command == null) return ;
            _command.Execute();
        }
    }
}