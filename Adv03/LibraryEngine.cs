using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Adv03
{

    public delegate string BookD(Book book);
    public class LibraryEngine
    {
       public static void ProcessBooks(List<Book> blist ,BookD fPtr)
        {
            foreach (Book B in blist)
            {
              Console.WriteLine(fPtr(B));
            }         

        }

        public static void BookFunc(List<Book> blist, Func<Book, string> fPtr)
        {
            foreach (Book B in blist)
                Console.WriteLine(fPtr(B));
        }




    }
}
