class Program
{
    public static void Main(string[] args)
    {
        double initialAmount = 1000000;
        
        while (true)
        {

            Console.WriteLine("Welcome to Bancolombia ATM, select your option:");
            Console.WriteLine(
                "1) Check your balance. \n2) Deposit money \n3) Withdraw money. \n4) Request a loan. \n0) Exit");
            Console.WriteLine("-----------------------------");
            
            if (!int.TryParse(Console.ReadLine(), out int option))
            {
                Console.WriteLine("Invalid option. Please enter a number between 1 and 4.");
                continue;
            }
            
            try
            {
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

                        if (double.TryParse(Console.ReadLine(), out double depositAmount))
                        {
                            initialAmount += depositAmount;

                            Console.WriteLine($"You has had deposit of: ${depositAmount}");
                            Console.WriteLine($"Your new balance is: ${initialAmount}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount.");    
                        }
                        Console.WriteLine("-----------------------------");
                        break;

                    
                    // 3) To Withdraw money:
                    case 3:
                        Console.WriteLine("Option selected: 3) Withdraw money: ");
                        Console.WriteLine("Write the amount of money that you want to withdrawing: ");
                        
                        if (double.TryParse(Console.ReadLine(), out double withdrawMoney))
                        {
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
                                Console.WriteLine("Try a smaller amount.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount.");
                        }
                        
                        Console.WriteLine("-----------------------------");
                        break;

                    
                    // 4) To request a loan:
                    case 4:
                        
                        // Console.WriteLine("Option selected: 4) Request a loan: ");
                        // Console.Write("Enter the loan amount: ");
                        // if (double.TryParse(Console.ReadLine(), out double loan))
                        // {
                        //     initialAmount += loan;
                        //     Console.WriteLine($"You have received a loan of ${loan}");
                        //     Console.WriteLine($"Your new balance is: ${initialAmount}");
                        // }
                        // else
                        // {
                        //     Console.WriteLine("Invalid amount.");
                        // }
                        
                        Console.WriteLine("-----------------------------");
                        break;
                    
                    
                    // 0) To exiting of the program:
                    case 0:
                                    
                        

                            Console.WriteLine("0) Exit. ");
                            Console.WriteLine("Exiting of the system...");

                            Console.WriteLine("-----------------------------");
                            return;

                    default:
                        Console.WriteLine("You has selected an invalid option.");
                        break;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"It has presented an error {e.Message}");
                throw;
            }
        }
    }
}
