using Delegata.Delegate;
using Delegata.partOne;

namespace Delegata
{


    //step 0 ----> declaer data type
    public delegate int stringFunctionDelegate(string str);
    /// new with delegate
    ///the ref from delegate can refer to function or more [pointer to function]
    ///this function may be static function[class member function]
    ///this function may be non static function[object member function]
    ///But this function must be with the same signature of the delegate
    ///regardless function name & access modifier
    internal class Program
    {

        public static Action test()
        {
           // Action action = delegate () { Console.WriteLine(":)"); };
            Action action = () => Console.WriteLine(":)");
            return action;
        }
        static void Main(string[] args)
        {
            ///Delegate is a C# language feature
            ///Delegate Usages:
            /// 1. Functional programming
            /// 2. Event-Driven programming

            #region EX01
            // int x = 10;
            // string name;

            //// x = StringFunction.GEtUapperCharsCount;

            // //step01 : declare for refrence from delegate

            // stringFunctionDelegate reference;

            // // step 02 : intiliaze the delegate refrence[]
            // reference = new stringFunctionDelegate(StringFunction.GEtUapperCharsCount);

            // // reference = StringFunction.GEtUapperCharsCount; // Syntax sugar

            // // step 03
            // // use delegate ref [call function]
            // int res = reference.Invoke("Saeed Ahmed");
            // Console.WriteLine(res);
            // //invoke:It implements the function that the ref is consulting on
            // //reference("saeed ahmed"); //syntax sugar
            #endregion

            #region EX02
            //int[] num = { 5 , 6 , 2 , 7 , 1 };
            //SortingAlgorithms.BubbleSOrtAsc(num , compareFunction.compareGrt);
            //foreach (int i in num)
            //{
            //    Console.WriteLine(i);
            //}    
            #endregion

            #region Build in delegate
            /// 1.Predicate
            ///   can refer to function take one parameter only from any data type and 
            ///   mut be return bool

            /// 2.Func
            /// can refer to function take 0-16 parameter from any data type
            /// and must be return

            /// 3.Action
            /// 3.1 Non Generic version
            /// can refer to function take 0 parameter and must be void
            /// 3.2 Generic version
            /// can refer to function take 1-16 parameter rfom any data type and must be void 
            #endregion

            #region Anonymous Method - Lambda Expression
            ///#region Anonymous Method---> C# 2.0[2005]
            ///Predicate<int> predicate = delegate (int x) { return x%2 == 0; };
            ///bool flag = predicate(1);
            ///Console.WriteLine(flag);

            ///Lambda Expression -----> C# 3.0 [2007]
            ///FatArrow function
            /// => goes to
            /// Predicate<int> predicate =  (x)=>   x%2 == 0; ;
            ///bool flag = predicate(1);
            ///Console.WriteLine(flag);
            #endregion

            #region Function return function
            //Action action = test();
            //action.Invoke();
            //action(); //syntax suger

            //test()();
            #endregion

            #region task

            string[] s1 = { "Mohaeb al saed" };
            string[] s2 = { "Radwa Ahour", "Moreed" };
            string[] s3 = { "Alain de botton" };


            var date1 = new DateTime(2024, 8, 1, 7, 0, 0);

            List<Book> book = new List<Book>
            {
             new ("12", "the duck who wished to stay black", s1, date1, 200),
             new ("112", "Status Anxiety", s2, date1, 200),
             new ("32", "Tholathiat Garnada", s3, date1, 100),
            };

            // User Defined Delegate Datatype
            BookFuncDel<Book> fPtr = BookFunction.GetTitle;
            LibraryEngine.ProcessBooks(book, fPtr);

            //Built-in delegate Datatype
            Func<Book, string> BCLP = BookFunction.GetAuthors;
        

            //anonymous Method (GetISBN)
            LibraryEngine.ProcessBooks(book, delegate (Book book) { return book.ISBN; });

            //Lambda Expression(GetPublicationDate)
            fPtr = book => book.PublicationDate.ToString();
            LibraryEngine.ProcessBooks(book, fPtr);
            #endregion
        }
    }
}
