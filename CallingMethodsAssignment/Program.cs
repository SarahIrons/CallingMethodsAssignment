using System;

namespace CallingMethodsAssignment
{
//    CALLING METHODS ASSIGNMENT

//   Perform these actions and create a console app that includes the following:


//Create a class. In that class, create three methods, each of which will take one integer parameter in and return an integer.The methods should do some math operation on the received parameter.Put this class in a separate.cs file in the application.


//In the Main() program, ask the user what number they want to do the math operations on.


//Call each method in turn, passing the user input to the method.Display the returned integer to the screen.
  


        class Program
        {
            public static int inputNumber { get; set; }
            static void Main(string[] args)
            {
                Console.WriteLine("Please enter a number here, and we will perform math operations with it: ");
                string line = Console.ReadLine();
                var inputNumber = Int32.Parse(line); //this takes user input and converts to integer.
                var operatorObject = new OperationMethods(); //this instantiates the class. This will allow return of the math methods.
                Console.WriteLine(operatorObject.AdditionMethod(inputNumber));//this takes user number and runs the addition method (adding 4) and displays the result to user.
                Console.WriteLine(operatorObject.SubtractionMethod(inputNumber));//this takes user number and runs subtraction method (subtracting 3) and displays result to user.
                Console.WriteLine(operatorObject.DivideMethod(inputNumber));//this takes user number and runs the divide method (dividing by 3) and displays result to user.
            
              
      
            }
        }
    }

    

