
using System.Drawing;
using Microsoft.VisualBasic.CompilerServices;
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using DemoApplication;


//Console.WriteLine("Enter your first number"); //5
//int firstNum = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter your second number"); //5
//int secNum = Convert.ToInt32(Console.ReadLine());

int myAge = 17;
int votingAge = 18;

//if (myAge >= votingAge)
//{
//    Console.WriteLine("You are eligible to vote");
//}
//else
//{
//    Console.WriteLine("You are not eligible to vote");
//}

//if (5 > 2)
//{
//    Console.WriteLine("5 is greater than 2");
//}
//else
//{
//    Console.WriteLine("5 is les than 2");

//}

Console.WriteLine(myAge >= votingAge ? "5 is greater than 2" : "5 is less than 2");



int num;
//delegate
Func<int,bool>  testFunction = num => num % 2 == 0;
Func<int,int,int> addNumber = (num1, num2) => num1 + num2;

static void EvenNumber(int number)
{
    if (number % 2 == 0)
    {
        Console.WriteLine("even number");
    }
}
static int AddNUmber(int firstNum, int secondNum)
{
     return firstNum + secondNum;
}


//Console.WriteLine("Enter your name");
//string name = Console.ReadLine();



//string num1 = Console.ReadLine();
//int n1 = int.Parse(num1);


//string myName = "Jon shrestha";
//int index = myName.IndexOf("s");
//string lastName = myName.Substring(index, 8);


//Console.WriteLine("Enter your name");
//string value = Console.ReadLine();
//Console.WriteLine("Name = {0}", value);
//Console.WriteLine("Name is " + value);
//Console.WriteLine($"Your name is {value} ");

//String[] name = { "Ram", "Shyam", "Sita", "Alex", "A", "B","C" };
//for (int i = 0; i < name.Length; i++)
//{
//    Console.WriteLine(name[i]);

//}




//int[] numbers = {1,2,3,4,5};
//Console.WriteLine(numbers[3]);

//if (20 > 30)
//{
//    Console.WriteLine("20 is greater than 18");
//}
//else if (20 < 30)
//{
//    Console.WriteLine("20 is less than 18");
//}

//Loop.LoopExample();

// 1 to 10
//Output
//2 4 6 8 10 

//Enter a number : 5

//Console.WriteLine("enter a positive number"); //123
//int number = Convert.ToInt32(Console.ReadLine());

//int i = 1;
//while (i <= number)
//{
//    Console.WriteLine($"{i} ^ 2 = {Math.Sqrt(i)}");
//    i = i + 1;
//}

//int sum = 0;
//do
//{
//    int lastDigit = number % 10;
//    sum = sum + lastDigit;
//    number = number / 10;

//} while (number > 0);

// Predefined password


//10 

//int sum = 0;
//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine("Enter element  " + i);
//    int num = Convert.ToInt32(Console.ReadLine());
//    sum = sum + num;
//}

//Console.WriteLine("The sum = " + sum);
//Console.WriteLine("Avereage = " + sum / 10);



//int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

//for (int i = 0; i < numbers.GetLength(0); i++)
//{
//    for (int j = 0; j < numbers.GetLength(1); j++)
//    {
//        Console.WriteLine(numbers[i, j]);
//    }
//}

//string[] arr = { "A", "B", "C", "D" };
//for (int i = 3; i >= 0; i--)
//{
//    Console.WriteLine(i);
//}

// data type  varialeName = value;

//int age = 25;
//string name = "Ram";
//char firstLetter = 'A';
//bool flag = true;
//double amount = 25.5;


//Console.WriteLine("Enter your age"); //25 "25"
//int age = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Your age is " + age); //Concatenation
//Console.WriteLine("Your age = {0} ", age); // Place holder syntax 
//Console.WriteLine($"Your age is {age}"); // Interpolation

//Console.WriteLine("Enter size of array");
//int arraySize = Convert.ToInt32(Console.ReadLine());


//char[] element = new char[arraySize];
//for (int i = 0; i < arraySize; i++)
//{
//    Console.WriteLine($"Enter element {i} ");
//    element[i] = Convert.ToChar(Console.ReadLine());
//}

//// "A", "B", "C", "D"   result D C B A

//for (int j = 0; j < arraySize/2; j++)
//{
//    char temp = element[arraySize];
//    element[j] = temp;

//}


//Console.Write("Enter the size of the array: ");
//int size = Convert.ToInt32(Console.ReadLine());

//char[] characters = new char[size];

//// Input array elements
//for (int i = 0; i < size; i++)
//{
//    Console.Write($"Enter element {i + 1}: ");
//    characters[i] = Convert.ToChar(Console.ReadLine());
//}

//// A B C D rsults D C B A 

//// Reverse the array elements using a for loop
//for (int i = 0; i < size / 2; i++)
//{
//    // Swap elements at position i and (size - 1 - i)
//    char temp = characters[i]; 
//    characters[i] = characters[size - 1 - i];
//    characters[size - 1 - i] = temp;
//}

//// Print the reversed array
//Console.Write("Reversed array: ");
//foreach (char element in characters)
//{
//    Console.Write(element + " ");
//}

//double sum = AddNumber(5,5);
//double sum1 = AddNumber(1.2, 1.3);

//Console.WriteLine(sum1);

//int myAge = 21;



// string MyMethod(string name, int age)
//{
//    return $"Your name is {name} and age is {age}";
//}

//int MyMethod2()
//{
//    return 2;
//}

//write a method(function) that add two numbers as parameter


//double AddNumber(double firstNum, double secondNum)
//{
//    return firstNum + secondNum;
//}
//int AddNumber(int firstNum, int secondNum)
//{
//    return firstNum + secondNum;
//}

//bool IsEligibleToVote(int age)
//{
//    int legalAge = 18;
//    return age >= legalAge;
//}

//int age1 = 16;
//if (IsEligibleToVote(age1))
//{
//    Console.WriteLine("You are eligible to vote");
//}
//else
//{
//    Console.WriteLine("sorry you are not eligible to vote");
//}

//Car toyota = new Car();
//toyota.color = "red";
//Console.WriteLine(toyota.color);
//toyota.Drive();

//Car volvo = new Car();
//volvo.color = "blue";
//Console.WriteLine(volvo.color);

//Employee class  fields: Id, Name, Department, method : displayName 

//GetFullName()  - parameter : firstname,lastname
//output FullName = Ram Shrestha

//Write a function called GetAge and
//take DOB as parameter 
// and return age.
// Enter a Date of Birth : 1995 
// Your age is 28. 

//string fullName = GetFullName("Ram", "Shrestha");

//Console.WriteLine(fullName);
//Console.WriteLine(GetFullName("Alex", "Shrestha"));

//String GetFullName(string fname, string lname)
//{
//    return fname + " " + lname;
//}




//method
//int getAge(int year)
//{
//    int currentYear = 2023;
//    int calculatedAge = currentYear - year;
//    return calculatedAge;
//}

//Console.WriteLine("Enter a date of birth"); //1995
//int year = int.Parse(Console.ReadLine());


//int age = getAge(year);
//Console.WriteLine("your age is " + age);


// user input CCYY/MM/DD /2023/12/20
//Write a function called ConvertToYYMMDD that convert CCYY/MM/DD to YYMMDD
// output : YYMMDD  //231220

//Question
//Input : 23.12.20
//Output : 2023-12-20


//BankAccount k1 = new BankAccount("12345", 1000);
//k1.GetBalance();
//k1.Deposit(500);
//k1.GetBalance();
//k1.Withdraw(20000);
//k1.GetBalance();



//string car = "BMW";
//string car2 = "Toyota";
//string car3 = "Ford";

//string[] carCollection;

//carCollection =  new string[] { "BMW", "Toyota", "Ford" };
//int[] evenNumber = {2,4,8,10};

//carCollection[0] = "ABC";

//foreach(string c in carCollection)
//{
//    Console.WriteLine(c);
//}
//Console.WriteLine(carCollection[2]);


// Outer loop
//for (int i = 1; i <= 5; ++i)
//{
//    //Console.WriteLine("Outer: " + i);  // Executes 2 times

//    // Inner loop
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write("*");
//        //Console.WriteLine(" Inner: " + j); // Executes 6 times (2 * 3)
//    }
//    Console.WriteLine();
//}

//string[] start = { "*", "**", "***" };



//void DisplayMyName(string name = "Harry", int age = 25)
//{
//    Console.WriteLine("Name is " + name);
//    Console.WriteLine("Age is " + age);

//}

//string getAge()
//{
//    string age = "25";
//    return age;
//}

//int AddNumber(int firstNumber, int secondNumber)
//{
//    return firstNumber + secondNumber;
//}

//float AddNumber(float firstNumber, float secondNumber)
//{
//    return firstNumber + secondNumber;
//}

//Addition a1 = new Addition();
//a1.AddNumber(2.5, 2);

//Car c1 = new Car();
//c1.Drive();

////Addition.AddNumber(5,6);

//Console.WriteLine(getAge());

//DisplayMyName("Alex", 28);

//Console.WriteLine("Enter a balance");
//int balance = int.Parse(Console.ReadLine());

//BankAccount ram = new BankAccount("12345", 1000);
//ram.GetBalance();

//ram.Deposit(500);
//ram.GetBalance();

//ram.Withdraw(2000);
//ram.GetBalance();

//Person e1 = new Employee();
//e1.myMethod();
//e1.secondMethod();

//Person s1 = new Student();
//s1.myMethod();
//s1.secondMethod();

//var e = EnglishLevel.Intermediate;
//Console.WriteLine(e);

//string writeText = "Hello World! This is sample test file..";  // Create a text string
//File.WriteAllText("H:\\Dot net training\\File demo\\test.txt", writeText);  // Create a file and write the content of writeText to it

//string readText = File.ReadAllText("H:\\Dot net training\\File demo\\test.txt");  // Read the contents of the file
//Console.WriteLine(readText);  // Output the content

//try
//{
//    int firstNumber = 10;
//    int secondNumber = 0;

//    int result = firstNumber / secondNumber;

//    Console.WriteLine(result);

//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//    throw new Exception("Cannot be divided by 0");
//}

//finally
//{
//    Console.WriteLine("Finally");
//}

//List<Employee> employeeList = new List<Employee>();
//Employee e1 = new Employee() { Id = 1, Name = "Ram", gender = "Male" };
//employeeList.Add(e1);

Console.ReadLine();



