using BankEncapsulation;

var account = new BankAccount2();
Console.WriteLine("How much would you like to deposit");
var amountToDeposit = double.Parse(Console.ReadLine());

account.Deposit(amountToDeposit);

Console.WriteLine($"Thank you! Your balance is now {account.GetBalance()}");
Console.ReadLine();