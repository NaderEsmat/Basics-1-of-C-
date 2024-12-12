namespace Basics_1_of_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question 1 

            //int number = Convert.ToInt32 (Console.ReadLine());  
            //Console.WriteLine (number);

            #endregion

            #region Question 2

            //string password = "route345";
            // Convert.ToInt32 (password);
            // Error : System.FormatException: 'The input string 'route345' was not in a correct format.'

            #endregion

            #region Question 3

            //float num1 = 2.15f;
            //float num2 = 5.234115f;
            //float sum = num1 + num2;
            //Console.WriteLine(sum);
            //// No Errors sum = 7.384115
            #endregion

            #region Question 4

            //string word = "RouteAcademy";
            //int part = word.IndexOf("A");

            //string NewWord = word.Substring(part);
            //Console.WriteLine(NewWord);




            #endregion

            #region Question 5

            //int number1 = 5;
            //int number2 = 10;
            //Console.WriteLine(number2); //10
            //number2 = number1;
            //Console.WriteLine(number2); // The value became 5 

            #endregion

            #region Question 6

            //Point p1 = new Point();
            //Console.WriteLine(p1.x); // 5
            //Console.WriteLine(p1.y); // 10

            //Point p2 = new Point();
            //p2 = p1; 
            //Console.WriteLine(p2.x); // 5 
            //Console.WriteLine(p2.y); // 10

            //p2.x = 6;
            //p2.y = 11;
            //Console.WriteLine(p2.x); // 6
            //Console.WriteLine(p2.y); // 11
            #endregion

            #region Question 7 

            //string word1 = "Route";
            //string word2 = "Academy";
            //string FullWord =  word1 + " " + word2;
            //Console.WriteLine(FullWord);
            #endregion

            #region Question 8
            //Console.WriteLine("Enter a value for principal : ");
            //Decimal Principal = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("Enter a value for Time : ");
            //Decimal Time = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("Enter a value for Rate : ");
            //Decimal Rate = Convert.ToDecimal(Console.ReadLine());
            //Decimal Result = Principal * Time * Rate;
            //Console.WriteLine(Result);
            #endregion

            #region Question 9

            //decimal Weight = Convert.ToDecimal (Console.ReadLine());
            //decimal Height = Convert.ToDecimal (Console.ReadLine());

            //decimal BMI = Weight / (Height * Height);
            //Console.WriteLine (BMI);

            #endregion

            #region Question 10 


            //    int T = Convert.ToInt32(Console.ReadLine());
            //string result = (T < 10) ? "Just Cold" : ((T > 30) ? "Just Hot" : "Just Good");
            //Console.WriteLine(result);

            #endregion

            #region Question 11

            //DateTime date1 = new DateTime(2024, 12, 10);
            //Console.WriteLine($" Today's date : { date1: dd,MM,yyyy}");
            //Console.WriteLine($" Today's date : {date1: dd/MM/yyyy}");
            //Console.WriteLine($" Today's date : {date1: dd-MM-yyyy}");

            #endregion


            #region Question 12 

            // DateTime date = new DateTime(2024, 6, 14);
            //Console.WriteLine($"The event is on {date:MM/dd/yyyy}");

            // c) The event is on 06/14/2024 
            #endregion

            #region Question 13
            //int d;
            //d = Convert.ToInt32(!(30 < 20));
            //Console.WriteLine(d);
            // The value of D = 1 

            #endregion

            #region Question 14 

            // Console.WriteLine(13 / 2 + " " + 13 % 2);
            // 6 1 
            #endregion


            #region Question 15 
            //int num = 1, z = 5;

            //if (!(num <= 0))
            //    Console.WriteLine(++num + z++ + " " + ++z);
            //else
            //    Console.WriteLine(--num + z-- + " " + --z);

            // 7 7 

            #endregion






        }
    }
}
