using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // An array is a collection of similar data types, arrays starts at index zero,
            // you can access the elements of an array with their index number
            // int [] eventNumbers = new int [3];
            // eventNumbers[0] = 2;
            // eventNumbers[1] = 4;
            // eventNumbers[2] = 6;
            // Console.WriteLine(eventNumbers[1]);
            // int [] students = {1, 2, 3, 6};
            // foreach (var student in students)
            // {
            //     Console.WriteLine(student + 2);
            // }
            // this array skips one name
            // string [] students = {"andrew", "mubarak", "paul", "ife", "precious", "sarah", "bernice"};
            // for (int i = 0; i < 7; i+=2)
            // {
            //     Console.WriteLine(students[i]);
            // }
            // students[0] = "Elijah";
            // students[1] = "Bernice";
            // students[2] = "Sarah";
            // students[4] = "Andrew";
            // Console.WriteLine(students[1]);
            //Types of Arrays
            //multidimensional arrays may be initialized by specifying bracketed values for each row
            // the example below is an array with 3 rows and 4 columns,the row comes first before the column
            //in this case 3 is the number of rows while 4 is the number of columns, [,] shows it is a multi-
            //dimensional array
            // you have to specify the number of rows and columns
            //use double for loops and not for each loop in a multidimensional array
            int [,] matNumbers = new int [3,4]
             {
                {0,1,2,3},
                {4,5,6,7},
                {8,9,10,11}
            };
            // to print a single element in a multidimensional array
            Console.WriteLine(matNumbers[2,3]);
        //     for (int i = 1; i < 3; i++)   
        //     {
        //         Console.WriteLine($"this is row {i} \n");
        //         for (int j = 0; j < 3; j++)
        //         {
        //             Console.WriteLine(matNumbers[i,j]);
        //         }
        //     }
            
        }
    }
}
