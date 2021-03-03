using System;

namespace Part_6_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            //1
            int min;
            int max;
            int median;
            //2
            int percentage;
            double amount = 0;
            double above = 0;
            //3
            int n, lastnum, sum = 0;
            //4
            int minValue;
            int maxValue;
            int random;


            //-----------------------------------------------------------------------------------
            //1
            Console.WriteLine("Please enter a minimum value:");
            min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a maximum value:");
            max = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter an integer that's inbetween your minimum and maximum values:");
            median = Convert.ToInt32(Console.ReadLine());

            while (median < min || median > max)
            {

                Console.WriteLine("Please enter an integer that's inbetween your minimum and maximum values:");
                median = Convert.ToInt32(Console.ReadLine());
            }




            Console.WriteLine($"{median} is in between the maximum and minimum values!");

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            //2

            do
            {
                Console.WriteLine("Please enter a percentage for a test score (You will be prompted for 3 test scores): ");
                Console.WriteLine("Press enter to submit.");
                percentage = Convert.ToInt32(Console.ReadLine());

                if (percentage >= 70)
                {
                    amount += 1;
                    above += 1;



                }
                else if (percentage < 70)
                {
                    amount += 1;

                }



            } while (amount != 3);

            Console.WriteLine(above);
            Console.WriteLine(amount);

            Console.WriteLine($"Your percentage of scores above 70 is {(above) / (amount) * 100}%");

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            //3
            Console.WriteLine("Enter a number:");
            lastnum = Convert.ToInt32(Console.ReadLine());

            for (n = 1; n <= lastnum; n += 2)
            {

                sum += n;

            }

            Console.WriteLine($"The sum of the odd numbers between 1 and {lastnum} is {sum}");

            //4
            Console.WriteLine("Please enter a minimum value: ");
            minValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a maximum value: ");
            maxValue = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= 25; i++)
            {

                random = generator.Next(minValue, maxValue);
                Console.WriteLine(random);
            }











            Console.ReadLine();









        }
    }
}