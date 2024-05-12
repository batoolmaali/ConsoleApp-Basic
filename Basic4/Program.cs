using Basic4.Models;


Employee emp=new Employee();
string salary = emp.calcSalary("Batool",500, 8000, 5);
Console.WriteLine(salary);

//for loop
//for (initialization; condition; iteration)
//{
    // Code to be executed
//}

//for (int i = 0; i <= 10; i++)
//{
//    Console.WriteLine(i);  
//}

//// even
//for (int i = 2; i <= 10; i+=2)
//{
//    Console.WriteLine("even "+ i);
//}

////odd
//for (int i = 1; i <= 10; i += 2)
//{
//    Console.WriteLine("odd " +i);
//}

////odd + even
//for (int i = 0; i <= 10; i++)
//{
//    if (i % 2 == 0)
//    {
//        Console.WriteLine("even " + i);
//    }
//    else
//    {
//        Console.WriteLine("odd " + i);
//    }
//}
Console.WriteLine("///////////////////////////////////////////////////");
//////////////////////////////////////////////////////////////////////

//aray
//datatype[] x = new Dtadatype[];
//1-// Create an array of four elements, and add values later from input (Console.ReadLine())

//string[] names = new string[4];

//ex
string all = "";
string[] names = new string[4];
for (int i = 0; i <names.Length; i++)
{
    names[i] = Console.ReadLine();
    all += names[i] + " ";
}
Console.WriteLine(all);

//ex
string x = ""; //=> output as string 1234
int sum = 0; // => output total
int[] numbers = new int[4];
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = int.Parse(Console.ReadLine());
    //x = x + numbers[i];
    sum = sum + numbers[i];
}
Console.WriteLine(sum);

///////////////////////////////////////////////////////////////////
//2- // Create an array of four elements and add values right away 
//string[] Names = new string[4] { "batool", "ahmad", "mohd", "khaled" };
//ex
string[] Names = new string[4] { "batool", "ahmad", "mohd", "khaled" };
for (int i = 0; i < Names.Length; i++)
{
    Console.WriteLine(Names[i]);
}
///////////////////////////////////////////////////////////////////
//3-// Create an array of four elements without specifying the size 
//ex
string[] cars = new string[] { "Volvo", "BMW", "Ford", "Mazda" };
for (int i = 0; i < cars.Length; i++)
{
    Console.WriteLine(cars[i]);
}
////////////////////////////////////////////////////////////////////
//4- // Create an array of four elements, omitting the new keyword, and without specifying the size
string[] Cars = { "Volvo", "BMW", "Ford", "Mazda" };
for (int i = 0; i < Cars.Length; i++)
{
    Console.WriteLine(Cars[i]);
}

//Note :  if you declare an array and initialize it later, you have to use the new keyword:

// Declare an array
//string[] cars;

//// Add values, using new
//cars = new string[] { "Volvo", "BMW", "Ford" };  // correct

//// Add values without using new (this will cause an error)
//cars = { "Volvo", "BMW", "Ford"}; // error

///////////////////////////////////////////////////////////////////////////////////////
///foreach
///
string[] cars2 = { "Volvo", "BMW", "Ford", "Mazda" };
foreach (string i in cars2)
{
    Console.WriteLine("foreach " + i);
}
