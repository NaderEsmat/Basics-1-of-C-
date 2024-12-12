namespace Demo_1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Variable Declaration 
            //int number; // Declaration 

            // We can Declare and intitalize in the same line 
            //int variable = 5;

            //Console.WriteLine(number); // UnAssigned local variable -> doesn't have a value to print it
            //Console.WriteLine(variable);

            //variable = 6;
            //Console.WriteLine(variable); // Re-Assigning the value of variable 
            // The output will be 5 6  
            #endregion

            #region NewKeyword
            //Point p1 = new Point();
            ///* What happened ?
            //The new keyword did the following : 
            //                             1- Allocate a space at the heap memory 
            //                              2 - Initiallized the space with a default value which is 0 
            //                               3- Called the user default constructor if exists
            //                                4- Assigned the address of objects in class point to p1 variable

            //      Note : Before new Point() --> p1 refers to Null 
            // */
            //p1.x = 10;
            //Console.WriteLine(p1.x); // 10

            //Console.WriteLine(p1.y); // 0 Default value 

            //Point p2 = new Point(); // making  new object of class point (the tempelate)

            //p2 = p1; // putting the values of p1 in the new object p2 , so p2.x should be ??? 10 and p2.y ??? 0 Default

            //Console.WriteLine(p2.x); // 10
            //Console.WriteLine(p2.y); // 0 
            #endregion

            #region Casting

            ////Implicit Casting 
            //int x = 5;
            //double y = x; //Valid
            //Console.WriteLine(y);

            //// Double number = 3.5;
            ////  int num2 = number;   // Error 

            //     // Explicit Casting  -> Manualy 

            //   Double number = 3.5;
            //   int num2 = (int)number;   // Error 
            //Console.WriteLine(num2);





            #endregion

            #region Parsing and Convert 

            // Parse: Function
            //Console.WriteLine("Enter Your Age: ");
            //int Age= int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Your GPA: ");

            //double GPA= double.Parse(Console.ReadLine());

            //Console.WriteLine("Age: " + Age);
            //Console.WriteLine("GPA: " + GPA);


            // Convert

            // Console.WriteLine(value: "Enter Your Age: ");

            // int Age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Your GPA: ");
            //double GPA double.Parse(Console.ReadLine());
            //  Console.WriteLine("Age: = " + Age);
            //Console.WriteLine("GPA: "+GPA); 



            // TryParse function

            //Console.WriteLine( "Enter Your Age: ");
            //int Age;
            //bool Flag =int.TryParse(Console.ReadLine(), out Age);
            ////Console.WriteLine("Enter Your GPA: ");
            ////double GPA double.Parse(Console.ReadLine());
            //Console.WriteLine("Age: " +Age);
            //Console.WriteLine("Flag "+ Flag);

            #endregion
        }
    }
}
