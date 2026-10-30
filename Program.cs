// account (Name + Balance)
string accountName = "Khalil";

decimal balance = 100.00m;

Console.WriteLine($"Account : {accountName} Your Balance Is : {balance}");

bool runnig = true;

while (runnig)
{
    Console.WriteLine("\n1.Check Balance \n2.Deposit sum \n3.Withdraw Cash \n4.Exit Menu");
    Console.Write("Choose: ");
    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            Console.WriteLine($"Your Balance is {balance}");
            break;
        case "2":
            Console.WriteLine("Enter an amount");
            decimal dep = decimal.Parse(Console.ReadLine());
                if (dep > 0)
            {
                balance += dep;
                Console.WriteLine($"You Diposted {dep} . New Balance is : {balance}");
            }else
            {
                Console.WriteLine("Enter a Positive Amount ");

            }
            break;
        case "3":
            Console.WriteLine("Enter an amount");
            decimal wdc = decimal.Parse(Console.ReadLine()); 
                if (wdc > balance)
            {
                
                Console.WriteLine("You Don't Have Enough Money");
            }
            else
            {
                balance -= wdc;
                Console.WriteLine($"Your Withdraw is {wdc} . New Balance is {balance}");

            }
            break;
        case "4":
            Console.WriteLine("Exiting Menu...");
            runnig = false;
            break;
        default:
            Console.WriteLine("INVALID OPTION !!");
            break;
            
    }
}