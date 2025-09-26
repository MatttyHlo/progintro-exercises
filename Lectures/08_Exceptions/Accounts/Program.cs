int[] accounts = {903, 716, 67};

int GetAccountNumber ()
{
    Console.WriteLine("Enter an account number: ");
    int num = -1;

    while(num == -1){

        try {
            int inputNum = Convert.ToInt32(Console.ReadLine());

            if (inputNum < 0 || inputNum >= 3)
            {
                Console.WriteLine("Invalid input, try again:");
            }
            else
            {
                num = inputNum;
            }
        }
        catch
        {
            Console.WriteLine("Invalid input, try again:");
        }
    }

    return num;
}

void PrintAccountState (int accountId)
{
    Console.WriteLine("Account " + accountId + " contains " + accounts[accountId]);
}

while (true) {
    int accountId = GetAccountNumber();
    PrintAccountState(accountId);
}
