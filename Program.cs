class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Bancolombia ATM, select your option:");
        Console.WriteLine("1) Check your balance. \n2) Deposit money \n3) Withdraw money. \n4) Exit");
        
        int option = int.Parse(Console.ReadLine());
        
        //Console.WriteLine(option.GetType());

        double initialAmount = 1000000;

        Console.WriteLine("-----------------------------");
        
        // Conditional to choose your option:
        switch (option)
        {
            // 1) To know your current balance:
            case 1:
                Console.WriteLine("Option selected: \n1) Check your balance: ");
                Console.WriteLine($"Your balance is: ${initialAmount}");
                Console.WriteLine("-----------------------------");
                break;
            
            // 2) To deposit money:
            case 2:
                Console.WriteLine("Option selected: 2) Deposit money: ");
                Console.WriteLine("Write the amount of money that you want to deposit: ");
                double depositAmount = double.Parse(Console.ReadLine());
                
                initialAmount += depositAmount;

                Console.WriteLine($"You has had deposit of: ${depositAmount}");
                Console.WriteLine($"Your new balance is: ${initialAmount}");
                
                Console.WriteLine("-----------------------------");
                break;
            
            // 3) To Withdraw money:
            case 3:
                Console.WriteLine("Option selected: 3) Withdraw money: ");
                Console.WriteLine("Write the amount of money that you want to withdrawing: ");
                double withdrawMoney = double.Parse(Console.ReadLine());
                
                if (withdrawMoney <= initialAmount)
                {
                    initialAmount -= withdrawMoney;
                    Console.WriteLine($"You just withdrew ${withdrawMoney}");
                    Console.WriteLine($"Your new balance is: ${Math.Round(initialAmount, 2)}");
                }
                else
                {
                    double unbalance = Math.Round(withdrawMoney - initialAmount, 2);
                    Console.WriteLine("You do not have enough money to withdraw.");
                    Console.WriteLine($"You has exceeded your balance by: ${unbalance}");
                    Console.WriteLine("You could try a minor amount of money.");
                }
                
                Console.WriteLine("-----------------------------");
                break;
            
            // To exiting of the program:
            case 4:
                Console.WriteLine("Option selected: 4) Exit: ");
                
                
                Console.WriteLine("-----------------------------");
                break;
            
            // case 5:
            //     Console.WriteLine("Option selected: 1) Check your balance");
            //     
            //     
            //     break;
            
            default:
                Console.WriteLine("");
                break;
        }


    }
}
