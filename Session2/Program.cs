using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Session2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region stirng Formatatting
            // stirng Formatatting
            // Equation : X+ Y = 12 


            //  int X = 3; int Y= 4;
            //////String Concatnation 
            ////string Message = "Equation : " + X + " + " + Y + " = " + (X + Y);
            ////Console.WriteLine(Message);
            ////String : Immutable -> Cant Change its Value After Creation 

            //// 2 . String Format 
            //string Message = string.Format("Equation: {0} + {1} = {2}", X , Y, X+Y);
            //Console.WriteLine(Message);

            // 3. String Intepolution 
            //$ : 
            //string Message = $"Equation : {X} + {Y} = {X+Y}";
            //Console.WriteLine(Message);
            #endregion


            #region Control Statements


            // Control Statements
            // Control Statements : 1. Conditional Control Statements (if statement , Switch Case)

            // Control Statements : 2. Loop Control Statements (For , Foreach , While , Do While )
            //Console.WriteLine("hello");
            //Console.WriteLine("hello");
            //Console.WriteLine("hello");
            //Console.WriteLine("hello");




            // Control Statements : 1. Conditional Control Statements (if statement , Switch Case)
            //Console.WriteLine("Enter Number Of Month in The 1st Quarter ");
            //int MonthNumber = int.Parse(Console.ReadLine());
            // 1 -- > Jan
            // 2 -- > Feb 
            // 2 --> Mar


            //Console.WriteLine( "Jan" );
            //Console.WriteLine("Feb");
            //Console.WriteLine("Mar");
            //if (/*Expession*/) 
            //{
            //        // Code 
            //        // This Code Will Be Executed When The Condition Is True
            //}
            //1. Using if
            //if (MonthNumber == 1) 
            //{
            //    Console.WriteLine( "Jan" );

            //}
            // if (MonthNumber == 2) 
            //{
            //    Console.WriteLine("Feb");
            //}
            //if (MonthNumber == 3 )
            //{
            //    Console.WriteLine("Mar ");
            //}

            //if (MonthNumber == 1)
            //{
            //    Console.WriteLine("Jan");

            //}
            //else if (MonthNumber == 2)
            //{
            //    Console.WriteLine("Feb");
            //}
            //else if (MonthNumber == 3)
            //{
            //    Console.WriteLine("Mar ");
            //}
            //else
            //{ Console.WriteLine("Invaled Month Number "); }


            //2. Using Switch
            //switch (/*Expression*/)
            //{

            //    case 0:
            //}
            //Console.WriteLine("Enter Number Of Month in The 1st Quarter ");
            //int MonthNumber = int.Parse(Console.ReadLine());

            ////Jump Table 
            //switch (MonthNumber)
            //{
            //    case 1 :
            //        Console.WriteLine("Jan");
            //        break;
            //    case 2:
            //        Console.WriteLine("Feb");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mar");
            //       break ; 
            //        default: Console.WriteLine("Invaled Month Number ");
            //        break;
            //}


            #endregion

            #region EX01

            //Console.WriteLine("Enter Your Name : ");
            //string NAme = Console.ReadLine();
            //// Hi Ahmed 
            //if (NAme == "Ahmed " || NAme == "ahmed")
            //{
            //    Console.WriteLine("Hi Ahmed ");
            //}

            //Console.WriteLine("Enter Your Name : ");
            //string NAme = Console.ReadLine();

            //switch (NAme)

            //{
            //    case "Ahmed":
            //        Console.WriteLine("Hi Ahmed ");
            //        break;
            //    case "Omar":
            //        Console.WriteLine("Hi Omar ");

            //}
            #endregion
            #region EX02

            //Console.WriteLine("Enter U Age");
            //inn Age = int.Parse(Console.ReadLine());
            //Using IF

            //if (Age > 18)
            //{
            //    Console.WriteLine("Welcaome :");
            //}
            //else if (Age < 18)
            //{
            //    Console.WriteLine("Welcaome :");
            //}
            //else (Age = 18 )
            //{
            //    {
            //        Console.WriteLine("Equal :");
            //    }
            //}
            //Using  Switch
            //switch (Age)

            //{
            //    case > 18:
            //            Console.WriteLine("Welcaome :");
            //            break;
            //    case < 18:
            //            Console.WriteLine("Welcaome :");
            //        break;
            //    default:
            //        Console.WriteLine("eq");
            //        break;
            //}
            #endregion

            #region C# 7.0
            //object Object = new object();
            //Object = "Ahmed ";
            //Object = 1;

            //switch (Object)
            //{
            //    case int X when X > -12:

            //        Console.WriteLine("int Object ");
            //break;
            //    case string X when X.Length > 5:

            //        Console.WriteLine("string Object");
            //        break ;
            //}


            #endregion

            #region C# 8.0

            //string Input = Console.ReadLine();
            ////1
            ////2
            ////3
            //string Output = Input switch 
            //{ 

            //   "1" => "Option 1",
            //   "2" => "Option 2",
            //   "3" => "Option 3",
            //   _ => "Unsupport Option "

            //};
            //Console.WriteLine(  Output);
            #endregion

            #region stirng Formatatting 1,2,3 Loop

            // Control Statements : 2. Loop Control Statements (For , Foreach , While , Do While )
            //            Console.WriteLine("Hello World");
            //1. For Loop 
            //for (/*Statement*/ ; /*Expression*/; /*Statement*/ )
            //{ 
            ////Code 
            //// Call Conv This call Code Will Repeated
            //}


            //for (Console.WriteLine("Hello 1"); i <10; Console.WriteLine("Hello 2");)
            //{
            //    Console.WriteLine("Hello World");
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);

            //}

            //.2 Foreach 
            //int[] Numbers = { 1, 2, 3, 4 };
            ////for (int i = 0; i < Numbers.Length; i++)
            ////{

            ////    Console.WriteLine(Numbers[i]);
            ////}

            //foreach (int N in Numbers)
            //{
            //    Console.WriteLine(N);
            //}

            //While 

            //while ( /*Expression*/)
            //{
            //    //Code
            //    // That Code Will Repeated While The Expression Is True
            //}

            //while ( true)
            //{
            //    Console.WriteLine("Hallow World");
            ////}
            //int i = 1;
            //while (i <= 10 )
            //{
            //    Console.WriteLine("Hallow World");
            //    i++;
            //}
            //Do - While 
            //do
            //{
            //    //Code
            //    //That Code Will Executed First 
            //}

            //while (/*Expression*/);
            //int i = 11;

            //do
            //{
            //    Console.WriteLine("Hallow World");
            //    i++;

            //} while (i <= 10);
            //int Number;
            //bool flag;
            //do {
            //    Console.WriteLine("Even Number : ");
            //    flag = int.TryParse(Console.ReadLine(), out Number);

            //} while (Number % 2 != 0 || flag ==false);


            //Console.WriteLine(Number);

            #endregion


            #region String

            //  //string : Reference Type : HEAP (Class)
            //  //Immutable type : Cant Change Its Value After Creatation 
            //  string S01;
            //  // Declare For Reference (Pointer) From Type 'String'
            //  //S01 : Can Refet  To Obhect From 'String' 
            //  //S01 : Refet To Null 
            //  //8 Bytes Will Be Allocated At Stack For Referncr 'S01'
            //  //8 Bytes Will Be Allocated At Heap

            ////  S01 = new string("Ahmed");
            //  S01 = "Ahmed"; //Syntex Suger
            //  //New 
            //  //1. Allocte The Number Of Required Bytes For The Object AT Heap
            //  //2. Initialized The Allocated Bytes With  Default Values 
            //  //3. Call User-defined Constryuctor Is Exists
            //  //4. Assign The Object TO The Reference
            //  Console.WriteLine(S01.GetHashCode()); // ID : Indicte Address
            //  S01 = "Ali";
            //  //1. Allocte The Number Of Required Bytes For The Object AT Heap
            //  //2. Initialized The Allocated Bytes With  Default Values 
            //  //3. Call User-defined Constryuctor Is Exists
            //  //4. Assign The Object TO The Reference
            //  Console.WriteLine(S01.GetHashCode());
            //  S01 = "Yasmeen";
            //  //1. Allocte The Number Of Required Bytes For The Object AT Heap
            //  //2. Initialized The Allocated Bytes With  Default Values 
            //  //3. Call User-defined Constryuctor Is Exists
            //  //4. Assign The Object TO The Reference
            //  Console.WriteLine(S01.GetHashCode());

            //string Message = "Hello";
            //Console.WriteLine("Messge :" + Message);
            //Console.WriteLine("Messge :" + Message.GetHashCode);
            //Console.WriteLine();
            //Message += "Ahmed";
            //Console.WriteLine("Messge :" + Message);
            //Console.WriteLine("Messge :" + Message.GetHashCode);
                     

            #endregion











        }
    }
}
