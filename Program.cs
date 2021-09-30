using Day13GenericsAssg;
using System;

namespace Day13Assignment
{
    class Program
    {
        public static object UC1_Generics { get; private set; }
        public static object UC2_Generics { get; private set; }

        static void Main(string[] args)
            {
                #region UC1
                //Test Case 1.1
                //Console.WriteLine("Find Maximum Number in Test Case1.1");
                //int Result = UC1_Generics.MaxIntNum(44, 33, 22);
                //Console.WriteLine(Result);
                //Test Case 1.2
                //Console.WriteLine("Find Maximum Number in Test Case1.2");
                //int Result2 = UC1_Generics.MaxIntNum(33, 44, 22);
                //Console.WriteLine(Result2);
                //Test Case 1.3
                //Console.WriteLine("Find Maximum Number in Test Case1.3");
                //int Result3 = UC1_Generics.MaxIntNum(33, 22, 44);
                //Console.WriteLine(Result3);
                #endregion

                #region UC2
                //Test Case 1.1
                //Console.WriteLine("Find Maximum Number in Test Case1.1");
                //double Result = UC2_Generics.MaxFloatNum(44.4, 33.3, 22.22);
               //Console.WriteLine(Result);
                //Test Case 1.2
                //Console.WriteLine("Find Maximum Number in Test Case1.2");
                //double Result2 = UC2_Generics.MaxFloatNum(33.3, 44.4, 22.2);
                //Console.WriteLine(Result2);
                //Test Case 1.3
                //Console.WriteLine("Find Maximum Number in Test Case1.3");
                //double Result3 = UC2_Generics.MaxFloatNum(33.3, 22.2, 44.4);
                //Console.WriteLine(Result3);
                #endregion

                #region UC3
                //Test Case 1.1
                //Console.WriteLine("Find Maximum Number in Test Case1.1");
                //string Result = UC3_Generics.MaxStringNum("Peach", "Apple", "Banana");
                //Console.WriteLine(Result);
                //Test Case 1.2
                //Console.WriteLine("Find Maximum Number in Test Case1.2");
                //string Result2 = UC3_Generics.MaxStringNum("Apple", "Peach", "Banana");
                //Console.WriteLine(Result2);
                //Test Case 1.3
                //Console.WriteLine("Find Maximum Number in Test Case1.3");
                string Result3 = UC3_Generics.MaxStringNum("Apple", "Banana", "Peach");
                Console.WriteLine(Result3);
                #endregion

                #region Refactor 1
                int[] intArray = { 22, 33, 44 };
                //UC_Refactor1<int> generic = new UC_Refactor1<int>(intArray);
                //generic.PrintMaxValue();
                //double[] doubleArray = { 11.1, 22.2, 33.3 };
                //UC_Refactor1<double> genericDouble = new UC_Refactor1<double>(doubleArray);
                //genericDouble.PrintMaxValue();
                //string[] stringArray = { "H", "E", "Y" };
                //UC_Refactor1<string> genericString = new UC_Refactor1<string>(stringArray);
                //genericString.PrintMaxValue();
                #endregion

                #region
                //int[] A = { 11, 22, 33, 44, 55, 66 };
                //UC4_Generics<int> gens = new UC4_Generics<int>(A);
                //Console.WriteLine("Values Sorted");
                #endregion

                #region
                //int[] A = { 11, 22, 33, 44, 55, 66 };
               //UC5_GenericsAssignment<int> gen = new UC5_GenericsAssignment<int>(A);
                //gen.PrintMaxValue();
                #endregion
            }
        }
    }

   
