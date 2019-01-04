using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//N*N 크기의 배열을 만들었다. (배열 방번호는 1번부터) 배열에 들어가는 수는 A[i][j]
//이차원배열 A, 이차원배열 B

namespace Baek1300
{
    class Program
    {
        static void Main(string[] args)
        {
            int Aarray = 0;
            Console.WriteLine("배열 A의 크기를 입력하세요(정수만)");
            string input = Console.ReadLine();
            //int number1 = Int32.Parse(input); //149p    
            int num = Convert.ToInt32(input); // 151p
                                              //Console.WriteLine("input" + input);
                                              //Console.WriteLine("number:"+ num);

            Console.WriteLine();
            int[,] A = new int[num, num];

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    A[i, j] = (i + 1) * (j + 1);

                    //Console.WriteLine("i: " + i, "j: " + j);
                }
            }
            //A[0, 0] = 1;  //0 [1*1]
            //A[0, 1] = 2;  //1 [1*2]
            //A[0, 2] = 3;  //2 [1*3]
            //A[1, 0] = 2;  //3 [2*1]
            //A[1, 1] = 4;  //4 [2*2]
            //A[1, 2] = 6;  //5 [2*3]
            //A[2, 0] = 3;  //6 [3*1]
            //A[2, 1] = 6;  //7 [3*2]
            //A[2, 2] = 9;  //8 [3*3]
            foreach (var i in A)
            {

                Console.WriteLine($"{i}");
            }

            int Barray = num * num;

            int[] B = new int[Barray]; //B

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    B[i] = A[i, j]; //TO DO

                }
            }


            Array.Sort(B);


            foreach (var i in B)
            {
                Console.WriteLine($"{i}");
            }


        }
    }
}
