using System;
using System.ComponentModel;
namespace assignment
{
    class Task1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Choice :\n 1.Grades \n 2.Conversion \n 3.Tickets \n 4.Login" +
                " \n 5.calculator \n 6.Pollutants \n 7.RPSgame \n 8.Fine \n 9.Traffic \n 10.Library  ");
            int choice=Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:grades();
                break;
                case 2:Conversion();
                break;
                case 3:Tickets();
                break;
                case 4:Login();
                break;
                case 5:Calculator();
                break;
                case 6:Pollutants();
                break;
                case 7:RPSgame();
                break;
                case 8:Fine();
                break;
                case 9:Traffic();
                break;
                case 10:Library();
                break;
                default: Console.WriteLine("Invalid Choice");
                break;

            }
        }
        
        public static void grades()
        {
            Console.WriteLine("Enter Your marks");
            int marks = Convert.ToInt32(Console.ReadLine());
            if (marks >= 90 && marks <= 100)
            {
                Console.WriteLine("Your Grade is : A");
            }
            else if (marks >= 80 && marks <= 89)
            {
                Console.WriteLine("Your Grade is : B");
            }
            else if (marks >= 70 && marks <= 79)
            {
                Console.WriteLine("Your Grade is : C");
            }
            else if (marks >= 60 && marks <= 69)
            {
                Console.WriteLine("Your Grade is : D");
            }
            else if (marks >= 0 && marks <= 59)
            {
                Console.WriteLine("Your Grade is : F");
            }
        }
       
        public static void Conversion()
        {
            Console.WriteLine("Enter your choice:\n 1.Fahrenheit \n 2.Celsius");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 2:
                    Console.WriteLine("Enter the Temperature");
                    float temperature = float.Parse(Console.ReadLine());
                    float celsius = (0.5f / 9.0f) * (temperature - 32);
                    Console.WriteLine(celsius + "C");
                    break;
                case 1:
                    Console.WriteLine("Enter the Temperature");
                    float temp = float.Parse(Console.ReadLine());
                    float fohren = (9.0f / 5.0f) * (temp + 32);
                    Console.WriteLine(fohren + "F");
                    break;
                default:
                    Console.WriteLine("Enter valid Input");
                    break;
            }

        }
        public static void Tickets()
        {
            Console.WriteLine("Enter Your Age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the show");
            string time = Console.ReadLine();
            if (age <= 12 && age > 0)
            {
                if (time == "matinee")
                {
                    Console.WriteLine("Ticket price is :" + (100 - 20));
                }
                else
                {
                    Console.WriteLine("Ticket Price is :" + 100);
                }
            }
            else if (age >= 12 && age <= 64)
            {
                if (time == "matinee")
                {
                    Console.WriteLine("Ticket price is :" + (200 - 50));
                }
                else
                {
                    Console.WriteLine("Ticket Price is :" + 200);
                }
            }
            else if (age >= 65 && age <= 100)
            {
                if (time == "matinee")
                {
                    Console.WriteLine("Ticket price is :" + (150 - 30));
                }
                else
                {
                    Console.WriteLine("Ticket Price is :" + 150);
                }
            }
            else
            {
                Console.WriteLine("Enter the valid age");
            }
        }
        public static void Login()
        {
            string oguserName = "Dileep@123";
            string ogpassword = "dileep@123";
            int count = 3;
            int x = 0;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter Username");
                string username = Console.ReadLine();
                Console.WriteLine("Enter PassWord");
                string password = Console.ReadLine();
                if (username == oguserName && password == ogpassword)
                {
                    Console.WriteLine("Successful Login");
                    break;
                }
                else if (username != oguserName && password == ogpassword)
                {
                    Console.WriteLine("Incorrect UserName");
                    x++;
                }
                else if (username == oguserName && password != ogpassword)
                {
                    Console.WriteLine("Incorrect Password");
                    x++;
                }
                else if (username != oguserName && password != ogpassword)
                {
                    Console.WriteLine("Incorrect UserName And PassWord");
                    x++;
                }
                if (x < 3) Console.WriteLine("Try Again");
            }

            if (x == 3) Console.WriteLine("Account locked");

        }
        public static void Calculator()
        {
            Console.WriteLine("Enter First Number:");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your choice:\n 1.Addition\n 2.Subtraction \n 3.Multiplication \n 4.Division");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Addition of " + first + " and " + second + " is " + (first + second));
                    break;
                case 2:
                    Console.WriteLine("Subtraction of " + first + " and " + second + " is " + (first - second));
                    break;
                case 3:
                    Console.WriteLine("Multiplication of " + first + " and " + second + " is " + (first * second));
                    break;
                case 4:
                    Console.WriteLine("Division of " + first + " and " + second + " is " + (first / second));
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
        public static void Pollutants()
        {
            Console.WriteLine("Enter the value of pollutants");
            int pollutants = Convert.ToInt32(Console.ReadLine());
            if (pollutants <= 50)
            {
                Console.WriteLine("Good");
            }
            else if (pollutants <= 100)
            {
                Console.WriteLine("Moderate");
            }
            else if (pollutants <= 200)
            {
                Console.WriteLine("Unhealthy");
            }
            else
            {
                Console.WriteLine("Very Dangerous");
            }
        }
        public static void RPSgame()
        {
            Console.WriteLine("Enter Rock or Paper or Scissor : player 1");
            String player1 = Console.ReadLine();
            Console.WriteLine("Enter Rock or Paper or Scissor : player 2");
            String player2 = Console.ReadLine();
            if ((player1 == "Rock" || player1 == "Scissor" || player1 == "Paper") && (player2 == "Rock" || player2 == "Scissor" || player2 == "Paper"))
            {
                if ((player1 == "Rock" && player2 == "Paper") || (player1 == "Paper" && player2 == "Scissor") || (player1 == "Scissor" && player2 == "Rock"))
                {
                    Console.WriteLine("Player 2 Won the Game");
                }
                else if (player1 == player2)
                {
                    Console.WriteLine("Tie");
                }
                else
                {
                    Console.WriteLine("Player 1 won the Game");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
        public static void Fine()
        {
            Console.WriteLine("Enter the days");
            int days = Convert.ToInt32(Console.ReadLine());
            if (days > 0 && days <= 7)
            {
                Console.WriteLine("You have No Fine");
            }
            else if (days > 7)
            {
                Console.WriteLine("Fine is : " + (days - 7) * 2 + " Rupees");
            }
            else
            {
                Console.WriteLine("Invalid Days");
            }
        }
        public static void Traffic()
        {
            Console.WriteLine("Enter the Time");
            int time = Convert.ToInt32(Console.ReadLine());
            if (time >= 0 && time <= 60)
            {
                Console.WriteLine("Red Signal");
            }
            else if (time > 60 && time <= 80)
            {
                Console.WriteLine("Green signal");
            }
            else if (time > 80 && time <= 85)
            {
                Console.WriteLine("Yellow signal");
            }
        }
        public static void Library()
        {
            int booksAvailable = 100;
            int userlimits = 3;
            int reservationDuration = 10;
            Console.WriteLine("Availabilty of Books are : 100");
            Console.WriteLine("How many Books you want ?");
            int books = Convert.ToInt32(Console.ReadLine());
            if (books > 100)
            {
                Console.WriteLine("Out of Stock");
            }
            else
            {
                Console.WriteLine(books + " books are reserved");
                Console.WriteLine("Enter the No.of Users");
                int users = Convert.ToInt32(Console.ReadLine());
                if (users > 3)
                {
                    Console.WriteLine(users + " users are not allowed");
                }
                else
                {
                    Console.WriteLine(users + " users are allowed");
                    Console.WriteLine("Enter the Duration");
                    int duration = Convert.ToInt32(Console.ReadLine());
                    if (duration > 10)
                    {
                        Console.WriteLine(duration + " days is not available");
                    }
                    else
                    {
                        Console.WriteLine(duration + " days is Avilable");
                        Console.WriteLine("Successfully Reserved");
                        Console.WriteLine("Thank you visit Again");
                    }
                }
            }
        }
    }
}

   



