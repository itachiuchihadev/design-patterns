namespace CRPattern
{
    public class MonkeyHandler : AbstractHandler
    {
        public override string Handle(string request)
        {
             if(request == "Monkey"){
                return $"Monkey Request : {request}";
            }
            else{
                return base.Handle(request);
            }
        }
    }
}