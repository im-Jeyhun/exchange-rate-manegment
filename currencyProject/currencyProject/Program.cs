// See https://aka.ms/new-console-template for more information


float oneUsd = 1.700f;
float oneRub = 0.0271f;
float oneTry = 0.1031f;
float oneEur = 1.8271f;

string[] currency = { $"1 USD - {oneUsd} AZN ", $"1 RUB - {oneRub} AZN ", $"1 TRY - {oneTry} AZN ", $"1 EUR - {oneEur} AZN" };
string[] currencyBox = { "USD", "RUB", "TRY", "EUR" };
string [] commandBox = { "/show-recent-currency-rates", "/find-currency-rate-by-code", "/calculate-amount-by-currecy", "/exit" };

Console.WriteLine(" W E L C O M E");
Console.WriteLine("PLS CHOOSE THE SUITABLE COMMAND, THEN INSERT IT : ");
Console.WriteLine("");
for (int i = 0; i < commandBox.Length; i++)
{
    Console.WriteLine(commandBox[i]);
}
Console.WriteLine();
Console.Write("PLS INSERT THE COMMAND : ");

string requiredCommand = Console.ReadLine();

/////////////////////////1///////////////////////////////////

    if (commandBox[0] == requiredCommand)
    {
        for (int i = 0; i < currency.Length; i++)
        {
            Console.WriteLine(currency[i]);

        }
        Console.WriteLine();
    while (true) { 
        Console.WriteLine("INSERT NEXT COMMAND ");

        string nextCommand = Console.ReadLine();

        if (currencyBox[0] == nextCommand)
        {
            Console.WriteLine(currency[0]);
            while (true) {
                Console.Write("INSERT AMOUNT : ");
                double requiredAmount = Convert.ToDouble(Console.ReadLine());
                if (requiredAmount >= 0)
                {
                    Console.WriteLine(requiredAmount * oneUsd);
                }
            }
        }
        else if (currencyBox[1] == nextCommand)
        {
            Console.WriteLine(currency[1]);
            while (true)
            {
                Console.Write("INSERT AMOUNT : ");
                double requiredAmount = Convert.ToDouble(Console.ReadLine());
                if (requiredAmount >= 0)
                {
                    Console.WriteLine(requiredAmount * oneRub);
                }
            }
        }

        else if (currencyBox[2] == nextCommand)
        {
            Console.WriteLine(currency[2]);
            while (true)
            {
                Console.Write("INSERT AMOUNT : ");
                double requiredAmount = Convert.ToDouble(Console.ReadLine());
                if (requiredAmount >= 0)
                {
                    Console.WriteLine(requiredAmount * oneTry);
                }
            }
        }

        else if (currencyBox[3] == nextCommand)
        {
            Console.WriteLine(currency[3]);
            while (true)
            {
                Console.Write("INSERT AMOUNT : ");
                double requiredAmount = Convert.ToDouble(Console.ReadLine());
                if (requiredAmount >= 0)
                {
                    Console.WriteLine(requiredAmount * oneEur);
                }
            }
        }
        else
        {
            Console.WriteLine("SORRY THIS COMMAND ISN'T HERE PLS TRY OTHER ONE ");
        }

    }
}
///////////////////////////////////////2////////////////////////////////////////////////
else if (commandBox[1] == requiredCommand)
    while (true) { 
{
    Console.Write("PLS INSERT CURRENCY : ");
    string nextCommand = Console.ReadLine();

    if (currencyBox[0] == nextCommand)
    {
        Console.WriteLine(currency[0]);
        while (true)
        {
            Console.Write("INSERT AMOUNT : ");
            double requiredAmount = Convert.ToDouble(Console.ReadLine());
            if (requiredAmount >= 0)
            {
                Console.WriteLine(requiredAmount * oneUsd);
            }
        }
    }
    else if (currencyBox[1] == nextCommand)
    {
        Console.WriteLine(currency[1]);
        while (true)
        {
            Console.Write("INSERT AMOUNT : ");
            double requiredAmount = Convert.ToDouble(Console.ReadLine());
            if (requiredAmount >= 0)
            {
                Console.WriteLine(requiredAmount * oneRub);
            }
        }
    }

    else if (currencyBox[2] == nextCommand)
    {
        Console.WriteLine(currency[2]);
        while (true)
        {
            Console.Write("INSERT AMOUNT : ");
            double requiredAmount = Convert.ToDouble(Console.ReadLine());
            if (requiredAmount >= 0)
            {
                Console.WriteLine(requiredAmount * oneTry);
            }
        }
    }

    else if (currencyBox[3] == nextCommand)
    {
        Console.WriteLine(currency[3]);
        while (true)
        {
            Console.Write("INSERT AMOUNT : ");
            double requiredAmount = Convert.ToDouble(Console.ReadLine());
            if (requiredAmount >= 0)
            {
                Console.WriteLine(requiredAmount * oneEur);
            }
        }
    }
    else
    {
        Console.WriteLine("SORRY THIS CURRENT ISN'T HERE PLS TRY OTHER ONE ");
    }

}
    }
///////////////////////////////////////3/////////////////////////////////////





else if (commandBox[2] == requiredCommand)
{
    while (true) { 
    Console.Write("PLS INSERT CURRENCY : ");
    string nextCommand = Console.ReadLine();

    if (currencyBox[0] == nextCommand)
    {
        Console.WriteLine(currency[0]);
        while (true)
        {
            Console.Write("INSERT AMOUNT : ");
            double requiredAmount = Convert.ToDouble(Console.ReadLine());
            if (requiredAmount >= 0)
            {
                Console.WriteLine(requiredAmount * oneUsd);
            }
        }
    }
    else if (currencyBox[1] == nextCommand)
    {
        Console.WriteLine(currency[1]);
        while (true)
        {
            Console.Write("INSERT AMOUNT : ");
            double requiredAmount = Convert.ToDouble(Console.ReadLine());
            if (requiredAmount >= 0)
            {
                Console.WriteLine(requiredAmount * oneRub);
            }
        }
    }

    else if (currencyBox[2] == nextCommand)
    {
        Console.WriteLine(currency[2]);
        while (true)
        {
            Console.Write("INSERT AMOUNT : ");
            double requiredAmount = Convert.ToDouble(Console.ReadLine());
            if (requiredAmount >= 0)
            {
                Console.WriteLine(requiredAmount * oneTry);
            }
        }
    }

    else if (currencyBox[3] == nextCommand)
    {
        Console.WriteLine(currency[3]);
        while (true)
        {
            Console.Write("INSERT AMOUNT : ");
            double requiredAmount = Convert.ToDouble(Console.ReadLine());
            if (requiredAmount >= 0)
            {
                Console.WriteLine(requiredAmount * oneEur);
            }
        }
    }
    else
    {
        Console.WriteLine("SORRY THIS CURRENT ISN'T HERE PLS TRY OTHER ONE ");
    }
}
}
////////////////////////////////////////4/////////////////////////////////////////
else  
{
    Console.WriteLine("bye bye");
    
}
