using System;

class PasswordGenerator
{
    static void Main()
    {
        // Określenie dostępnych zestawów znaków
        string lowercaseChars = "abcdefghijklmnopqrstuvwxyz";
        string uppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string numberChars = "0123456789";
        string symbolChars = "!@#$%^&*()_+";

        // Ustalenie długości hasła
        Console.Write("Podaj długość hasła: ");
        int passwordLength = int.Parse(Console.ReadLine());

        // Zdefiniowanie zmiennej, w której przechowywane będzie hasło
        string password = "";

        // Wygenerowanie losowych znaków i dodanie ich do hasła
        Random random = new Random();
        for (int i = 0; i < passwordLength; i++)
        {
            int characterSet = random.Next(4);
            switch (characterSet)
            {
                case 0:
                    password += lowercaseChars[random.Next(lowercaseChars.Length)];
                    break;
                case 1:
                    password += uppercaseChars[random.Next(uppercaseChars.Length)];
                    break;
                case 2:
                    password += numberChars[random.Next(numberChars.Length)];
                    break;
                case 3:
                    password += symbolChars[random.Next(symbolChars.Length)];
                    break;
            }
        }

        // Wyświetlenie wygenerowanego hasła
        Console.WriteLine("Twoje nowe hasło to: " + password);
        Console.ReadLine();
    }
}
