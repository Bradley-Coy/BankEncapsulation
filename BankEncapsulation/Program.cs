using BankEncapsulation;
var bankaccount1 = new BankAccount();
Console.WriteLine($"Hello, your current balance is {bankaccount1.GetBalance()}");
Console.WriteLine($"Would you like to make a deposit?");
Console.WriteLine("Please enter your deposit amount");
double x = double.Parse(Console.ReadLine());
bankaccount1.Deposit(x);
Console.WriteLine($"Your new balance is {bankaccount1.GetBalance()}");

