//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//// variables 
////Declaring Variables
////type variableName = value;

//// string

//// concat
//string FName = "batool", LName = "maali", Fullname = FName + LName;
//Console.WriteLine(Fullname);
//// anothor concat
//string str1 = "hello ", str2 = "world";
//string concat = string.Concat(str1, str2);
//Console.WriteLine(concat);
//// string length
//string txt = "hello ";
//Console.WriteLine("the length is :" + txt.Length);
//// upper / lower 
//string txt1 = "Hello World";
//Console.WriteLine(txt1.ToUpper());   // Outputs "HELLO WORLD"
//Console.WriteLine(txt1.ToLower());   // Outputs "hello world"
//// string index 
//string myString = "Hello";
//Console.WriteLine(myString.IndexOf("e"));  // Outputs "1"
//// substring
//string full = "john Deo";
//string last = full.Substring(5);
//Console.WriteLine(last);
//// replace
//string text = "Hello World";
//string newStr = text.Replace("Hello", "Hi");
//Console.WriteLine(newStr);

//// split 
//string text1 = "Hello World";
//string[] arr = text1.Split(" ");
//Console.WriteLine(arr[1]);

//// access string
//string text2 = "Hello World";
//Console.WriteLine(text2[1]);
//Console.WriteLine(text2[text2.Length - 1]);

////String Interpolation
//string firstName = "Moe", lastName = "Doe";
//string fname = $"My full name is: {firstName} {lastName}";
//Console.WriteLine(fname);

//// CONVERT int to string
//int age = 50;
//string convert = age.ToString();
//Console.WriteLine(convert);
//Console.WriteLine("////////////////////////////////////////////////////////////////");
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//// integer

//int number1 = 10;
//int number2 = 5;
//Console.WriteLine(number1 - number2);
//Console.WriteLine(number1 + number2);


//////Change the value of myNum to 20:
//int myNum = 15;
//myNum = 20; // myNum is now 20
//Console.WriteLine(myNum);

////// const => unchangeable and read-only:
//const int Number = 15;
//Console.WriteLine(Number);


//double Num = 3.14;
//Console.WriteLine(Num);

//Console.WriteLine("////////////////////////////////////////////////////////////////");
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//char letter = 'A';
//Console.WriteLine(letter);

//bool Tf = true;
//Console.WriteLine(Tf);

//DateTime Date = DateTime.Now;
//Console.WriteLine(Date);

//Console.WriteLine("////////////////////////////////////////////////////////////////");
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//// type casting
//// Implicit Casting (automatically) - converting a smaller type to a larger type size

//int myInt = 9;
//double myDouble = myInt;       // Automatic casting: int to double

//Console.WriteLine(myInt);      // Outputs 9
//Console.WriteLine(myDouble);   // Outputs 9

////Explicit Casting(manually) -converting a larger type to a smaller size type
//double mydouble = 9.78;
//int myint = (int)myDouble;    // Manual casting: double to int

//Console.WriteLine(mydouble);   // Outputs 9.78
//Console.WriteLine(myint);      // Outputs 9

//// convert method
//Console.WriteLine("////////////////////////////////////////////////////////////////");
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//// Read from input 

//// Console.ReadLine(); read only string
////Convert.ToInt32(); to convert string to int

//Console.WriteLine("Enter your name");
//Console.WriteLine("Enter first name");

//string Name1 = Console.ReadLine();
//Console.WriteLine("Enter last name");

//string Name2 = Console.ReadLine();
//string fulll = Name1 + " " + Name2;

//Console.WriteLine("my name is " + fulll);


//Console.WriteLine("Enter numbers");
//int Num1 = Convert.ToInt32(Console.ReadLine());
//int Num2 = Convert.ToInt32(Console.ReadLine());
//int Num3 = Convert.ToInt32(Console.ReadLine());

//int Concatenate = Num1 + Num2 + Num3;
//Console.WriteLine(Concatenate);
//Console.WriteLine("////////////////////////////////////////////////////////////////");
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
////// if/else condition

////Console.WriteLine("operation");
////string Numb1 = Console.ReadLine();
////string Numb2 = Console.ReadLine();
////string Operate = Console.ReadLine();


////if (Operate == "+")
////{
////    int result = Convert.ToInt32(Numb1) + Convert.ToInt32(Numb2);
////    Console.WriteLine(result);

////}
////else if (Operate == "-")
////{
////    int result = Convert.ToInt32(Numb1) - Convert.ToInt32(Numb2);
////    Console.WriteLine(result);
////}
////else if (Operate == "*")
////{
////    int result = Convert.ToInt32(Numb1) * Convert.ToInt32(Numb2);
////    Console.WriteLine(result);
////}
////else
////{
////    int result = Convert.ToInt32(Numb1) / Convert.ToInt32(Numb2);
////    Console.WriteLine(result);
////}

////Console.WriteLine("Enter your marks");
////Console.WriteLine("Enter mark 1");

////double mark1 = Convert.ToInt32(Console.ReadLine());
////Console.WriteLine("Enter mark 2");

////double mark2 = Convert.ToInt32(Console.ReadLine());
////Console.WriteLine("Enter mark 3");

////double mark3 = Convert.ToInt32(Console.ReadLine());
////Console.WriteLine("Enter mark 4");

////double mark4 = Convert.ToInt32(Console.ReadLine());
////Console.WriteLine("Enter mark 5");

////double mark5 = Convert.ToInt32(Console.ReadLine());

//// double Avg = (mark1 + mark2 + mark3+ mark4+ mark5)/ 5;
////string status = "";

////if (Avg > 85)
////{

////    Console.WriteLine("excellent");
////    status = "excellent";

////}
////else if (Avg <= 85 && Avg > 75)
////{
////    Console.WriteLine("verygood");
////}
////else if (Avg <= 75 && Avg >= 50)
////{
////    Console.WriteLine("good");
////}
////else
////{

////    Console.WriteLine("falied");
////}

////Console.WriteLine(" avg is " + Avg + status);

//Console.WriteLine("////////////////////////////////////////////////////////////////");
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//// switch

//string day = Console.ReadLine();

//switch (day)
//{
//    case "monday":

//        Console.WriteLine(" it's monday");
//        break;
//    case "Tuesday":

//        Console.WriteLine(" it's Tuesday");
//        break;
//    case "Wednesday":

//        Console.WriteLine(" it's Wednesday");
//        break;
//    case "Thursday":

//        Console.WriteLine(" it's Thursday");
//        break;

//    case "Friday":

//        Console.WriteLine(" it's  Friday");
//        break;
//    case "Saturday":

//        Console.WriteLine(" it's Saturday");
//        break;
//    case "Sunday":

//        Console.WriteLine(" it's Sunday");
//        break;
//    default:
//        Console.WriteLine("not a name of day");
//        break;

//}
//Console.WriteLine("////////////////////////////////////////////////////////////////");
//int Weather = Convert.ToInt32(Console.ReadLine());


//switch (Weather)
//{
//    case >= 25:
//        Console.WriteLine(" it's Hot");
//        break;

//    case < 25 and >= 20:
//        Console.WriteLine(" it's Warm");
//        break;
//    case < 20 and >= 15:
//        Console.WriteLine(" it's Cool");
//        break;
//    case < 15 and >= 10:
//        Console.WriteLine(" it's Cold");
//        break;
//    case < 10 and >= 5:
//        Console.WriteLine(" it's very Cold");
//        break;
//    case < 5:
//        Console.WriteLine(" it's freezing");
//        break;
//    default:
//        Console.WriteLine(" out of range");
//        break;

//}
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//// loop for / while

//// for
//for (int i = 0; i <= 10; i++)
//{
//    if (i % 2 == 0)
//    {
//        Console.WriteLine(i);

//    }

//}
//Console.WriteLine("enter number");
//int num= Convert.ToInt32(Console.ReadLine());
//int mlti = 1;
//for (int i = 0; i <= num; i++)
//{
//    Console.WriteLine(i);
//}
//for (int i = 1; i <= num; i++)
//{
//    mlti *= i;
//}
//Console.WriteLine(mlti);


//string[] tx = { "hi", "world" };
////Console.WriteLine(tx[0]);
//string max = " ";
//for (int i = 0; i < tx.Length; i++)
//{
//    Console.WriteLine(tx[i]);

//    //if (tx[i].Length > max.Length)
//    //{
//    //    max= tx[i];
//    //}
//}
//Console.WriteLine(max);


//Foreach Loop

//string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
//foreach (string i in cars)
//{
//    Console.WriteLine(i);
//}
//int[] numbers = { 1, 2, 3, 4, 5 };
//foreach (int i in numbers)
//{
//    Console.WriteLine(i);
//}
Console.WriteLine("////////////////////////////////////////////////////////////////");
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//// while
//int j = 0;
//while (j <= 10)
//{
//    Console.WriteLine(j);
//    j++;
//}

//// array

//string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
//Console.WriteLine(cars[0]);
//for (int i = 0; i < cars.Length; i++)
//{
//    Console.WriteLine(cars[i]);
//}

//cars[0] = "Opel"; // Change an Array Element
//Console.WriteLine(cars[0]);
//Console.WriteLine(cars.Length); // length

//int[] myNum = { 10, 20, 30, 40 };
//Console.WriteLine(myNum[0]);


//// functions

//// void => does not have a return value.

//void Area(int x, int y)
//{
//    int Area = x * y;
//    Console.WriteLine(Area);

//}

//Area(5, 5);
//// return => has return value.

//int Area2(int x, int y)
//{
//    int Area = x * y;
//    return Area;
//}

//var AR = Area2(5, 5);
//Console.WriteLine(AR);



////////////////////////////////////////////////////////////////////////////////////
//void Area()
//{
//Console.WriteLine("Enter number");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter another number");
//int num2 = Convert.ToInt32(Console.ReadLine());

//int div = num1 / num2;

//try { 
// Console.WriteLine("Enter number");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter another number");
//int num2 = Convert.ToInt32(Console.ReadLine());

//int div = num1 / num2;
//Console.WriteLine(div);
//}
//catch 
//{
//    Console.WriteLine("error");
//}
//catch(Exception e)
//{
//    Console.WriteLine(e.Message);
//}
//    catch (DivideByZeroException e)
//    {
//        Console.WriteLine(e.Message);
//    }
//    catch (FormatException e)
//    {
//        Console.WriteLine(e.Message);
//    }
//    finally
//    {
//        // Code that always executes, regardless of whether an exception occurred or not
//        Console.WriteLine("End of program");
//    }
//    Console.ReadLine();

//}
//Area();


/////////////////////////////////////////////////////
///while loop
///
int i = 0;
while (i <= 5)
{
    Console.WriteLine(i);
    i++;
}

/////////////////////////////////////////////////////
///do- while loop
///
int x = 5;
int factorial = 1;
do
{
    factorial = factorial * x;
    x--;
} while (x > 0);
Console.WriteLine(factorial);

/////////////////////////////////////////////////////
///do- while loop
///















