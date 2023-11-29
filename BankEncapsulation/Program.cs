

using BankEncapsulation;
using System.IO.Pipes;
using System.Security.Cryptography.X509Certificates;

var account = new BankAccount2();
Console.WriteLine("How much would you like to deposit");
var amountToDeposit = double.Parse(Console.ReadLine());

varmylesAccount(amountToDeposit);

Console.WriteLine($"Thank you! Your balance is now mylesAccount.GetBalnce()");

void varmylesAccount(double amountToDeposit)
{
    throw new NotImplementedException();
}

