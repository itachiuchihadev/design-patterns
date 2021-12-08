namespace PPattern
{
    public class BookParser : IBookParser
    {
        private string _book;
        public BookParser(string book)
        {
            _book = book;
        }

        public int GetNumberOfCharacter()
        {
            return this._book.Length;
        }
        public string GetUpperCasesCharacter(){
            return this._book.ToUpper();
        }
    }
}