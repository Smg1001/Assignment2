using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2QualityAssurance
{
    public static class TriangleSolver
    {
        //Equilateral triangle: A triangle having all the three sides of equal length is an equilateral triangle.
        //Isosceles triangle: A triangle having two sides of equal length is an Isosceles triangle.
        //Scalene triangle: A triangle having three sides of different lengths is called a scalene triangle.
        //Triangle inequality theorum: the sum of the side lengths of any 2 sides of a triangle must exceed the length of the third side.

        public static string Analyze(double S1, double S2, double S3)
        {
            if (S1 >= 0 && S2 >= 0 && S3 >= 0)
            {
                bool triangle = false;
                //check inequality theorum
                if ((S1 + S2) > S3)
                {
                    if ((S2 + S3) > S1)
                    {
                        if ((S3 + S1) > S2)
                        {
                            triangle = true;
                        }
                    }
                }

                if (triangle)
                {
                    //check for Equilateral
                    if (S1 == S2 && S2 == S3)
                    {
                        return "E";
                    }
                    //check for Isosceles
                    if (S1 == S2 || S2 == S3 || S3 == S1)
                    {
                        return "I";
                    }
                    //check for Scalene
                    if (S1 != S2 || S2 != S3 || S3 != S1)
                    {
                        return "S";
                    }
                }
            }
                return "N";
            
        }
    }
}
