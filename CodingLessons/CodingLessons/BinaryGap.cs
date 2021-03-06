﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 A binary gap within a positive integer N is any maximal sequence of consecutive zeros that is surrounded by ones at both ends in the binary representation of N.

For example, number 9 has binary representation 1001 and contains a binary gap of length 2. The number 529 has binary representation 1000010001 and contains two binary gaps: one of length 4 and one of length 3. The number 20 has binary representation 10100 and contains one binary gap of length 1. The number 15 has binary representation 1111 and has no binary gaps. The number 32 has binary representation 100000 and has no binary gaps.

Write a function:

class Solution { public int solution(int N); }

that, given a positive integer N, returns the length of its longest binary gap. The function should return 0 if N doesn't contain a binary gap.

For example, given N = 1041 the function should return 5, because N has binary representation 10000010001 and so its longest binary gap is of length 5. Given N = 32 the function should return 0, because N has binary representation '100000' and thus no binary gaps.

Assume that:

N is an integer within the range [1..2,147,483,647].
Complexity:

expected worst-case time complexity is O(log(N));
expected worst-case space complexity is O(1).
Copyright 2009–2018 by Codility Limited. All Rights Reserved. Unauthorized copying, publication or disclosure prohibited.
*/


namespace CodingLessons
{
    public class BinaryGap
    {
        public static int binary_gap(int N)
        {
            int mod = 0, total_ceros = 0, total_unos = 0, max = 0, j = 0;

            while (N > 0)
            {
                j++;
                mod = N % 2;

                if (mod == 0)
                {
                    total_ceros++;

                    if (total_ceros == 2 && total_unos == 0)
                    {
                        total_ceros--;
                    }
                    else if (total_ceros == 1 && total_unos == 0)
                    {
                        total_ceros--;
                    }
                }
                else
                {
                    total_unos++;

                    if (total_unos == 2 && total_ceros == 0)
                    {
                        total_unos = 1;
                    }
                }

                if (total_ceros > max && total_unos == 2)
                {
                    max = total_ceros;
                    total_ceros = 0;
                    total_unos = 1;
                }
                if (total_ceros < max && total_unos == 2)
                {
                    total_ceros = 0;
                    total_unos = 1;
                }
                if (total_ceros == max && total_unos == 2)
                {
                    total_ceros = 0;
                    total_unos = 1;
                }

                N = N / 2;
            }
            return max;
        }
    }
}
