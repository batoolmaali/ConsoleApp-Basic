// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// using namespace to access class 
using Basic3;

// create new object
User user = new User();

// access variables in class / static value
string fname = user.FirtName = "batool";
string lname = user.LastName = "maali";
Console.WriteLine("Hi " + fname + " " + lname);

// access variables in class / value from input
Console.WriteLine("Enter your name");
string Fname = user.FirtName = Console.ReadLine();
string Lname = user.FirtName = Console.ReadLine();
string FullName = Fname + " " + Lname;
Console.WriteLine("Hello " + FullName);

// access method from class / static value

string full = user.FullName("batool", "maali");
Console.WriteLine(full);

// access method from class / value from input
Console.WriteLine("Enter your name from method");
string fN = Console.ReadLine();
string LN = Console.ReadLine();
string FL = user.FullName(fN, LN);
Console.WriteLine(FL);

//overloading different  number of parameters

Console.WriteLine("Enter your fullname from overloading1");
string f = Console.ReadLine();
string M = Console.ReadLine();
string L = Console.ReadLine();
string F = user.FullName(f, M, L);
Console.WriteLine(F);

//overloading different  type of parameters
Console.WriteLine("Enter your name and mark from overloading2");
string first = Console.ReadLine();
double mark = Convert.ToInt32(Console.ReadLine());
string output = user.FullName(first, mark);
Console.WriteLine(output);

// method calc avarege
Console.WriteLine("Enter your marks");
double mark1 = Convert.ToInt32(Console.ReadLine());
double mark2 = Convert.ToInt32(Console.ReadLine());
double mark3 = Convert.ToInt32(Console.ReadLine());
double avarege = user.calcAvg(mark1, mark2, mark3);
Console.WriteLine("your avarage is " + avarege);

// method calc avarege and status
Console.WriteLine("Enter your marks2");
double mark11 = Convert.ToInt32(Console.ReadLine());
double mark22 = Convert.ToInt32(Console.ReadLine());
double mark33 = Convert.ToInt32(Console.ReadLine());
string avarege1 = user.calcAvgAndStatus(mark11, mark22, mark33);
Console.WriteLine(avarege1);

// weather
Console.WriteLine("Enter the temp");
int temp = Convert.ToInt32(Console.ReadLine());
string weather = user.Weather(temp);
Console.WriteLine(weather);
