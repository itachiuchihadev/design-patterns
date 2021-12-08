namespace OPattern.Interfaces
{
    public interface ISubject
    {
        int State { get; set; }
        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void ChangeState();
        void HaveSomeTechLogic();
    }
}