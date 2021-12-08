namespace CRPattern
{
    public class CatHandler : AbstractHandler
    {
        public override string Handle(string request)
        {
             if(request == "Cat"){
                return $"Cat Request : {request}";
            }
            else{
                return base.Handle(request);
            }
        }
    }
}