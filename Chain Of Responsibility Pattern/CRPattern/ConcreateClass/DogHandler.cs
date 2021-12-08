namespace CRPattern
{
    public class DogHandler : AbstractHandler
    {
        public override string Handle(string request)
        {
            if(request == "Dog"){
                return $"Dog Request : {request}";
            }
            else{
                return base.Handle(request);
            }
        }
    }
}