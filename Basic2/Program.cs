// See https://aka.ms/new-console-template for more information


// creat object of Employee 
// classname objname= new classname();
// using file

using Basic2;


Employee employee = new Employee();
//string first= employee.fname = "batool";
//string first= employee.fname = "batool";
//string last = employee.lname = "maali";
Console.WriteLine("Enter your name");
//employee.fname = Console.ReadLine();
//employee.lname = Console.ReadLine();
//string full = employee.fname + " "+ employee.lname;
//Console.WriteLine(full);


string fname = Console.ReadLine();
string mname = Console.ReadLine();
string lname = Console.ReadLine();
string name = employee.getFullName(fname, mname, lname);
Console.WriteLine(name);
string full = employee.getFullName(fname, lname);
Console.WriteLine(full);
///////////////////////////////////////////////////////////////////////////////
Console.WriteLine("Enter your marks");
double m1 = Convert.ToInt32(Console.ReadLine());
double m2 = Convert.ToInt32(Console.ReadLine());
double m3 = Convert.ToInt32(Console.ReadLine());
double Avg = employee.calcAvg(m1, m2, m3);
Console.WriteLine(Avg);


