using System;

namespace PPattern
{
    public class ProxyParser : IBookParser
    {
        private BookParser _bookParser;
        private string _book;

        public ProxyParser(string book)
        {
            Console.WriteLine("Instantiate Proxy Parser.");
            _book = book;
        }

        private void InstantiateDependendObjects(){
             if(this._bookParser == null){
                Console.WriteLine("Now the BookParser Instance is Created.");
                this._bookParser = new BookParser(this._book);
            }
            else{
                Console.WriteLine("Use Cache Instatntiation of the Book Parser object.");
            }
        }
        public int GetNumberOfCharacter()
        {
            InstantiateDependendObjects();
            return this._bookParser.GetNumberOfCharacter();
        }

        public string GetUpperCasesCharacter()
        {
            InstantiateDependendObjects();
            return this._bookParser.GetUpperCasesCharacter();
        }
    }
}