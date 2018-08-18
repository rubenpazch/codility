using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] A = new int[] { 1, 3};
            System.Console.WriteLine(isMartian(A));

            int[] B = new int[] { 1,2,1,2,1,2,1,2,1 };
            System.Console.WriteLine(isMartian(B));

          int[] C = new int[] { 1, 3, 2};
             System.Console.WriteLine(isMartian(C));

             int[] D = new int[] { 1, 3, 3 ,2, 1 };
             System.Console.WriteLine(isMartian(D));

             int[] E = new int[] { 1, 2, -18,-18,1,2 };
             System.Console.WriteLine(isMartian(E));

             int[] F = new int[] { };
             System.Console.WriteLine(isMartian(F));

             int[] G = new int[] { 1 };
             System.Console.WriteLine(isMartian(G));

            System.Console.ReadLine();
            /*    int[] A = new int[] { 1, 2, 3, 1,0 };
                System.Console.WriteLine(hasSingleMaximum(A));
                int[] B = new int[] { 18};
                System.Console.WriteLine(hasSingleMaximum(B));
                int[] C = new int[] { 1, 2, 3, 0,1,3 };
                System.Console.WriteLine(hasSingleMaximum(C));
                int[] D = new int[] { 13,1,13,2,13,0,13,1,13};
                System.Console.WriteLine(hasSingleMaximum(C));
                int[] E = new int[] { };
                System.Console.WriteLine(hasSingleMaximum(D));
                int[] F = new int[] { -6,-6,-6 };
                System.Console.WriteLine(hasSingleMaximum(E));*/

        }

        public static int isMartian(int[] A)
        {
            int counter1 = 0;
            int counter2 = 0;
            int len = A.Length;

            for (int i = 0; i < len; i++)
            {
                if (len > 1)
                {
                    if (i != len - 1)
                    {
                        if (A[i] != A[i + 1])
                        {
                            if (A[i] == 1)
                            {
                                counter1++;
                            }
                            else if (A[i] == 2)
                            {
                                counter2++;
                            }
                        }
                        else
                        {
                            return 0;
                        }
                    }
                    else {
                        if (A[i] == 1)
                        {
                            counter1++;
                        }
                        else if (A[i] == 2)
                        {
                            counter2++;
                        }

                    }

                }
                else if (A[i] == 1)
                {
                    return 1;
                }
                else {
                    return 0;
                }
            }

            if (counter1 > counter2)
            {
                return 1;
            }
            else {
                return 0;
            }
        }


        public static int hasSingleMaximum(int[]A) {
            int max = A[0];

            for (int i = 0; i < A.Length; i++)
            {
                if (max < A[i])
                {
                    max = A[i];
                }
            }

            int counter = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (max == A[i])
                {
                    counter++;
                }
            }

            if (counter > 1)
            { return 0; }
            else
            { return 1; }
        }
     }
}
