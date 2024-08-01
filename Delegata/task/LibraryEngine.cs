using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegata.partOne
{
    public delegate string BookFuncDel<in T>(T i);
    internal class LibraryEngine
    {
        public static void ProcessBooks(List<Book> bList, BookFuncDel<Book> fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }
    }
}
