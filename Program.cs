using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2QualityAssurance
{
    class Program
    {
        static void Main(string[] args)
        {
            string menuAnswer = "";
            string sideInput = "";
            bool menuAnswered = false;
            bool getSides = false;
            bool side1Good = false;
            bool side2Good = false;
            bool analyze = false;
            double S1 = 0.00;
            double S2 = 0.00;
            double S3 = 0.00;

            //program loop so if you make a mistake it can go back to the top
            while (true)
            {
                while (!menuAnswered)
                {
                    Console.WriteLine("1.Enter triangle dimensions");
                    Console.WriteLine("2.Exit");

                    menuAnswer = Console.ReadLine();

                    switch (menuAnswer)
                    {
                        case "1":
                            menuAnswered = true;
                            getSides = true;
                            break;

                        case "2":
                            Environment.Exit(0);
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Please only enter 1 or 2\n");
                            break;
                    }
                    Console.Clear();
                }

                while (getSides)
                {
                    if (!side1Good)
                    {
                        Console.WriteLine("Please enter the length of side 1");
                        sideInput = Console.ReadLine();
                        if (validate(sideInput) == "T")
                        {
                            S1 = Convert.ToDouble(sideInput);
                            side1Good = true;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Only positive numbers please");
                        }
                    }

                    if (side1Good && !side2Good)
                    {
                        Console.WriteLine("Please enter the length of side 2");
                        sideInput = Console.ReadLine();
                        if (validate(sideInput) == "T")
                        {
                            S2 = Convert.ToDouble(sideInput);
                            side2Good = true;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Only numbers please");
                        }
                    }

                    if (side2Good)
                    {
                        Console.WriteLine("Please enter the length of side 3");
                        sideInput = Console.ReadLine();
                        if (validate(sideInput) == "T")
                        {
                            S3 = Convert.ToDouble(sideInput);
                            getSides = false;
                            analyze = true;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Only numbers please");
                        }
                    }

                    if (analyze)
                    {
                        Console.Clear();
                        switch (TriangleSolver.Analyze(S1, S2, S3))
                        {
                            case "E":
                                Console.WriteLine(" " + S1 + ", " + S2 + " and " + S3 + " make an Equilateral Triangle\n");
                                break;

                            case "I":
                                Console.WriteLine(" " + S1 + ", " + S2 + " and " + S3 + " make an Isosceles Triangle\n");
                                break;

                            case "S":
                                Console.WriteLine(" " + S1 + ", " + S2 + " and " + S3 + " make a Scalene Triangle\n");
                                break;

                            case "N":
                                Console.WriteLine(" " + S1 + ", " + S2 + " and " + S3 + " do not make a triangle\n");
                                break;

                            default:
                                Console.WriteLine(" " + S1 + ", " + S2 + " and " + S3 + " do not make a triangle\n");
                                break;
                        }
                        analyze = false;
                        getSides = false;
                        side1Good = false;
                        side2Good = false;
                        menuAnswered = false;

                        menuAnswer = "";
                        sideInput = "";

                        S1 = 0;
                        S2 = 0;
                        S3 = 0;
                    }
                }
            }
        }

        public static string validate(string number)
        {
            double dummy;
            if (double.TryParse(number, out dummy))
            {
                return "T";
            }
            return "F";
        }
    }
}
