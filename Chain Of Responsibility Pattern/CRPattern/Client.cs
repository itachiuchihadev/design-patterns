using System.Collections.Generic;
using System;

namespace CRPattern
{
    public class Client
    {
        public static void ClientCode(AbstractHandler abstractHandler)
        {
            List<string> list = new List<string>{ "Monkey", "Cat", "Dog" , "Squirel" };
            foreach(var request in list)
            {
                Console.WriteLine("Handling the request");
                var response = abstractHandler.Handle(request);
                if(response != null){
                    Console.WriteLine($"{response}");
                }
                else{
                    Console.WriteLine($"{request} is not handled.");
                }
            }
        }
    }
}