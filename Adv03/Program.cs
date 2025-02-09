using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Adv03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //List<Book> books = new List<Book>()
            //{

            //   new Book("1", "java", new [] { "Aya" , "ali" }, DateTime.Now,500),
            //   new Book("2", "Art", new [] { "rana" }, DateTime.Now ,5000),             
            //};

            //BookD Title = BookFunctions.GetTitle;
            //BookD auth = BookFunctions.GetAuthors;
            //BookD price = BookFunctions.GetPrice;

            //a
            //LibraryEngine.ProcessBooks(books, Title);
            //LibraryEngine.ProcessBooks(books, auth);
            //LibraryEngine.ProcessBooks(books, price);

            //b
            //Func<Book,string> func =BookFunctions.GetAuthors;
            //LibraryEngine.BookFunc(books, func);

            //c
            //Func<Book, string> Anonymous = delegate (Book book)
            //{
            //    return book.ISBN;
            //};
            //string Anon = Anonymous(books[1]) ;
            //Console.WriteLine(Anon);

            //d
            //LibraryEngine.BookFunc(books, Date =>Date.PublicationDate.ToShortDateString());

             

          
            #region Part3
            //List<int> numbers = new List<int>() {1,2,3,4,5,6,7,8,9,10};

            //Exist
            //bool Num = numbers.Exists(x => x > 10);
            //Console.WriteLine(Num);


            //Find

            //Console.WriteLine(string.Join(" , ", numbers));
            //int number = numbers.Find(x=> x>7);
            //Console.WriteLine(number);

            //Find All
            //List<int> number = numbers.FindAll(x => x > 7);
            //Console.WriteLine(string.Join(" , ", number));

            //Find index
            //int index = numbers.FindIndex(x => x > 7);
            //Console.WriteLine(index);
            //int index = numbers.FindIndex(8, x => x > 7);
            //Console.WriteLine(index);
            //int index = numbers.FindIndex(5,4, x => x > 7);
            //Console.WriteLine(index);

            //Find Last
            //int number = numbers.FindLast(x => x > 7);
            //Console.WriteLine(number);

            //Find Last Index
            //int index = numbers.FindLastIndex(x => x > 7);
            //Console.WriteLine(index);

            // Foreach 
            //numbers.ForEach(x=> Console.WriteLine(x));


            //TrueForAll
            //bool TrueF = numbers.TrueForAll(x => x > 0);
            // Console.WriteLine(TrueF);
            #endregion








        }


    }
}
