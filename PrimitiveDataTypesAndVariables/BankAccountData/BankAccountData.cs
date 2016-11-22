using System;

    class BankAccountData
    {
        static void Main()
        {
        string firstName = "Fred";
        string middleName = "Alex";
        string lastName = "Skor";
        decimal balance = 10000000;
        string bankName = "Raiffeisenbank (Bulgaria) EAD";
        object iban = "BG12RZBB12300012345678";
        object swift = "RZBBBGSF";
        ulong visa = 4987267652439993;
        ulong mastercard = 7875656456443547;
        ulong maestro = 894678466546356;
        Console.WriteLine("First Name: {0}", firstName);
        Console.WriteLine("Middle Name: {0}", middleName);
        Console.WriteLine("Last Name: {0}", lastName);
        Console.WriteLine("Balance: {0}", balance);
        Console.WriteLine("Bank Name: {0}", bankName);
        Console.WriteLine("IBAN: {0}", iban);
        Console.WriteLine("SWIFT: {0}", swift);
        Console.WriteLine("Credit Card Number - Visa : {0}", visa);
        Console.WriteLine("Credit Card Number - Mastercard : {0}", mastercard);
        Console.WriteLine("Credit Card Number - Maestro: {0}", maestro);
    }
    }

