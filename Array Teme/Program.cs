using System;

namespace Array_Teme
{
   class Program
   {
      static void Main(string[] args)
      {
         //Prob1
         Prob1AccessElements();
         //Prob2
         Prob2ReverseArray();
         //Prob3
         Prob3NumberOfOcc();
         //Prob4
         Prob4InsertANewItem();
         //Prob5
         Prob5RemoveAItem();
         //Prob6
         Prob6FindTheSum();
         //Prob7
         Prob7UniqueElem();
         //Prob8
         Prob8Merge2Arrays();
         //Prob9
         Prob9MaxAndMin();
         //prob10
         Prob10OddAndEven();
         //prob11
         Prob11SortAscending();
         //Prob12
         Prob12SortDescending();
         //Prob13
         Prob13SecondLargest();
         //Prob14
         Prob14SecondSmallest();
      }

      public static void Prob1AccessElements()
      {
         int[] myArray = new int[5] { 1, 2, 3, 4, 5 };
         Console.WriteLine("Problema1");
         foreach (var number in myArray)
         {
            Console.Write(number + ",");
         }
         Console.WriteLine("\n");
      }

      public static void Prob2ReverseArray()
      {
         Console.WriteLine("Problema2");
         Console.WriteLine("My initial array is:");

         int[] myArray = new int[5] { 1, 2, 3, 4, 5 };
         foreach (var number in myArray)
         {
            Console.Write(number + ",");
         }
         Console.WriteLine();

         Console.WriteLine("My reversed array is: ");
         int[] reversed = new int[myArray.Length];
         for (int i = myArray.Length-1; i >= 0 ; i--)
         {
            reversed[i] = myArray[i];
            Console.Write(reversed[i] + ",");
         }
         Console.WriteLine("\n");
         
      }

      public static void Prob3NumberOfOcc()
      {
         Console.WriteLine("Problema3");
         int[] myArray = new int[9] { 1, 2, 2, 4, 5, 6, 2, 3, 7 };
         int theElem = 2;
         int count = 0;
         Console.WriteLine("This is the array.");
         foreach (var item in myArray)
         {
            Console.Write(item + ",");
         }
         Console.WriteLine();
         Console.WriteLine($"The element we are lokking for is {theElem}.");
         foreach (var item in myArray)
         {
            if(item == theElem)
            {
               count++;
            }
         }
         Console.WriteLine($"The number of occurences is {count}.");
         Console.WriteLine("\n");
      }

      public static void Prob4InsertANewItem()
      {
         //Problema4
         Console.WriteLine("Problema4");
         int[] myArray = new int[5] { 1, 2, 3, 4, 5 };
         int[] newArray = new int[myArray.Length+1];
         int newElem = 6;


         Console.WriteLine("The initial array is:");
         foreach (var item in myArray)
         {
            Console.Write(item + ",");
         }
         Console.WriteLine();
         Console.WriteLine("The new array is:");


         for (int i = 0; i < newArray.Length; i++)
         {
            if(i == 0)
            {
               newArray[i] = myArray[i];
            }
            if (i == 1)
            {
               newArray[i] = newElem;
                 
            }
             if(i != 0 && i != 1)
            {
               newArray[i] = myArray[i-1];
            }
            Console.Write(newArray[i] + ",");           
         }
         Console.WriteLine("\n");
      }

      public static void Prob5RemoveAItem()
      {
         Console.WriteLine("Problema5");
         int[] myArray = new int[5] { 1, 2, 3, 4, 5 };
         int[] newArray = new int[myArray.Length-1];
         int itemToRemove = 3;
         bool condition = true;

         Console.WriteLine("The initial array is:");
         foreach (var item in myArray)
         {
            Console.Write(item + ",");
         }
         Console.WriteLine();
         Console.WriteLine($"The item to be removed is {itemToRemove}");
         Console.WriteLine("The new array is:");         

         for (int i = 0; i < newArray.Length; i++)
         {
            if(myArray[i] == itemToRemove)
            {
               condition = false;
            }
            if(condition == true)
            {
               newArray[i] = myArray[i];
            }
            if (condition == false)
            {
               newArray[i] = myArray[i + 1];
            }
            Console.Write(newArray[i] + ",");
         }
         Console.WriteLine("\n");

      }

      public static void Prob6FindTheSum()
      {
         Console.WriteLine("Problema6");
         int[] myArray = new int[5] { 1, 2, 3, 4, 5 };
         int sum = 0;


         Console.WriteLine("My array is:");
         foreach (var item in myArray)
         {
            Console.Write(item + ",");
         }
         Console.WriteLine();


         for (int i = 0; i < myArray.Length; i++)
         {
            sum += myArray[i];
         }
         Console.WriteLine($"the sum is: {sum}");
         Console.WriteLine("\n");
      }

      public static void Prob7UniqueElem()
      {
         Console.WriteLine("Problema7");
         int[] myArray = { 1, 2, 3, 2, 2, 5, 4, 6, 4, 7, 8, 3,};
         int replica = 0;
         Console.WriteLine("My array is:");
         foreach (var item in myArray)
         {
            Console.Write(item + ",");
         }
         Console.WriteLine();

         for (int i = 0; i < myArray.Length; i++)
         {
            replica = 0;
            for (int g = 0; g < myArray.Length; g++)
            {
               if(myArray[i] == myArray[g])
               {
                  replica++;
               }               
            }            
               if (replica < 2)
               {
                  Console.WriteLine($"Unique element: {myArray[i]}");
               }            
         }
         Console.WriteLine("\n");
      }

      public static void Prob8Merge2Arrays()
      {
         Console.WriteLine("Problema8");
         int[] myArray1 = { 1, 5, 32, 12, 55 };
         int[] myArray2 = { 10, 50, 3, 14, 29 };
         int[] mergedArr = new int[myArray1.Length + myArray2.Length];
         int g = 0;

         Console.WriteLine("First array:");
         foreach (var item in myArray1)
         {
            Console.Write(item + ",");
         }
         Console.WriteLine();


         Console.WriteLine("Second array:");
         foreach (var item in myArray2)
         {
            Console.Write(item + ",");
         }
         Console.WriteLine();

         Console.WriteLine("The merged arr is:");
         for (int i = 0; i < mergedArr.Length; i++)
         {
            if (i >= myArray1.Length)
            {
               mergedArr[i] = myArray2[g];
               g++;
            }
            else
            {
               mergedArr[i] = myArray1[i];
            }
            Console.Write(mergedArr[i] + ",");
         }
         Console.WriteLine();



         Console.WriteLine("The merged aray after being sorted:");
         for (int i = 0; i < mergedArr.Length - 1; i++)
         {
            for (int j = i + 1; j < mergedArr.Length; j++)
            {
               if (mergedArr[i] > mergedArr[j])
               {
                  var item = mergedArr[i];
                  mergedArr[i] = mergedArr[j];
                  mergedArr[j] = item;
               }
            }
         }
         foreach (var elem in mergedArr)
         {
            Console.Write($"{elem},");
         }
         Console.WriteLine("\n");
      }

      public static void Prob9MaxAndMin()
      {
         Console.WriteLine("Problema9");
         int[] myArray = new int[5] { 1, 2, 3, 4, 5 };
         int max= 0;
         int min = myArray[0];


         Console.WriteLine("My array is:");
         foreach (var item in myArray)
         {
            Console.Write(item + ",");
         }
         Console.WriteLine();

         for (int i = 0; i < myArray.Length; i++)
         {
            if(myArray[i] >= max)
            {
               max = myArray[i];
            }
            if(myArray[i] <= min)
            {
               min = myArray[i];
            }
         }
         Console.WriteLine($"The min is {min} and the max is {max}.");
         Console.WriteLine("\n");
      }

      public static void Prob10OddAndEven()
      {
         Console.WriteLine("Problema10");
         int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
         int countOdd = 0;
         int countEven = 0;
         

         //Determinam even si odd array length
         Console.WriteLine("My array is:");
         foreach (var item in myArray)
         {
            Console.Write(item + ",");
         }
         Console.WriteLine();

         for (int i = 0; i < myArray.Length; i++)
         {
            if(myArray[i] %2 == 0)
            {
               countEven++;
            }
            else
            {
               countOdd++;              
            }
            
         }
         
         int[] evenArr = new int[countEven];
         int[] oddArr = new int[countOdd];
         Console.WriteLine($"The length of the even array is {evenArr.Length}");
         Console.WriteLine($"The length of the odd array is {oddArr.Length}");



         //separate in 2 arrays
         Console.WriteLine("The array with even numbers is:");
         int evenNumPosition = 0;
         for (int g = 0; g < myArray.Length; g++)
         {
            if(myArray[g] %2 == 0)
            {
               evenArr[evenNumPosition] = myArray[g];               
               Console.Write(evenArr[evenNumPosition] + ",");
               evenNumPosition++;
            }
            
         }
         Console.WriteLine();



         Console.WriteLine("The array with odd numbers is: ");
         int oddNumberPositon = 0;
         for (int g = 0; g < myArray.Length; g++)
         {
            if(myArray[g] %2 == 0)
            {
               evenArr[oddNumberPositon] = myArray[g];               
               Console.Write(evenArr[oddNumberPositon] + ",");
               oddNumberPositon++;
            }
            
         }
         Console.WriteLine("\n");
      }

      public static void Prob11SortAscending()
      {
         Console.WriteLine("Problema11");
         int[] myArray1 = { 1, 5, 32, 12, 55, 7, 122, 6, 74};

         Console.WriteLine("My array:");
         foreach (var item in myArray1)
         {
            Console.Write(item + ",");
         }
         Console.WriteLine();



         for (int i = 0; i < myArray1.Length - 1; i++)
         {
            for (int j = i + 1; j < myArray1.Length; j++)
            {
               if (myArray1[i] > myArray1[j])
               {
                  var item = myArray1[i];
                  myArray1[i] = myArray1[j];
                  myArray1[j] = item;
               }
            }
         }

         Console.WriteLine("My array sorted:");
         foreach (var elem in myArray1)
         {
            Console.Write($"{elem},");
         }
         Console.WriteLine("\n");
      }

      public static void Prob12SortDescending()
      {
         Console.WriteLine("Problema13");
         int[] myArray1 = { 1, 5, 32, 12, 55, 7, 122, 6, 74 };

         Console.WriteLine("My array:");
         foreach (var item in myArray1)
         {
            Console.Write(item + ",");
         }
         Console.WriteLine();



         for (int i = 0; i < myArray1.Length - 1; i++)
         {
            for (int j = i + 1; j < myArray1.Length; j++)
            {
               if (myArray1[i] < myArray1[j])
               {
                  var item = myArray1[i];
                  myArray1[i] = myArray1[j];
                  myArray1[j] = item;
               }
            }
         }

         Console.WriteLine("My array sorted:");
         foreach (var elem in myArray1)
         {
            Console.Write($"{elem},");
         }
         Console.WriteLine("\n");
      }

      public static void Prob13SecondLargest()
      {
         Console.WriteLine("Problema13");
         int[] myArray = { 1, 12, 3, 6, 5, 11, 7, 8, 9 };
         int max = 0;
         int secondMax = 0;

         Console.WriteLine("My array:");
         foreach (var item in myArray)
         {
            Console.Write(item + ",");
         }
         Console.WriteLine();

         for (int i = 0; i < myArray.Length; i++)
         {
            if (myArray[i] >= secondMax)
            {
               secondMax = myArray[i];
            }
            if (myArray[i] >= max)
            {
               secondMax = max;
               max = myArray[i];
            }
            
         }
         Console.WriteLine($"The second largest number is {secondMax}");
         Console.WriteLine("\n");
      }

      public static void Prob14SecondSmallest()
      {
         Console.WriteLine("Problema14");
         int[] myArray = { 1, 12, 3, 6, 5, 11, 7, 8, 9 };
         int min = myArray[0];
         
         

         Console.WriteLine("My array:");
         foreach (var item in myArray)
         {
            Console.Write(item + ",");
         }
         Console.WriteLine();



         for (int i = 0; i < myArray.Length; i++)
         {
            if (myArray[i] <= min)
            {
               min = myArray[i];
            }            
         }

         


         int secondMin = min + 1000000000;//sau gasim max-ul si il adunam la min ca sa fim siguri        
         for (int i = 0; i < myArray.Length; i++)
         {
            if(myArray[i] <= secondMin && myArray[i] != min )
            {
               secondMin = myArray[i];
            }
         }
         Console.WriteLine($"The second smallest number is {secondMin}");
         Console.WriteLine("\n");
      }
   }
}
