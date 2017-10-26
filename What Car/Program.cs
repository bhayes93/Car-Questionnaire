using System;

namespace What_Car //An app that will tell you what car you will drive in the future based on how you answer the questions.
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;

            Console.WriteLine("How old are you?");
           int age = Convert.ToInt32(Console.ReadLine()); //Allows the Console.Readline to read integers instead of only strings
            // assign points according to your age.
            if (age>=0)// change results to complex decisive statements with multiple numbers
            {
                score++;
            }
            if (age<10) // The younger you are the more points you get because you are thinking ahead of your peers
            {
                score++;
            }
            if (age<20)
                {
                score++;
            }
            if (age<30)
                {
                score++;
            }
            if (age<40)
                {
                score++;
            }
            Console.WriteLine("How much do you plan on making annually in 10 years?");
                int salary = Convert.ToInt32(Console.ReadLine());
            if (salary>20000)
            {
                score++;
            }
            if (salary>40000) //The more you plan on making the better
            {
                score++;
            }
            if (salary>60000)
            {
                score++;
            }
            if (salary>80000)
            {
                score++;
            }
            Console.WriteLine("Do you eat out more than five times a week?");
                string answer = Console.ReadLine();
            if (answer=="yes")
            {
                score++;
            }
            if (answer=="no") 
            {
                score+=3;
            }
            Console.WriteLine("Your Overall Score is:", score);
            // Scoring Categories: 3-5, 6-7, 8-10, 11-12


            if (score <= 5) 
            {
                Console.WriteLine("You live at your mama house and ride a bicycle");
            }
            if (score>5 && score<8)
            {
                Console.WriteLine("A Bucket");
            }
            if (score>8 && score<11 ) 
            {
                Console.WriteLine("Toyota Camry");
            }
            if (score>11)
            {
                Console.WriteLine("Ashton Martin");
            }
        }
    }
}