using System;

class Program
{
    static string UppercaseWords(string value)
    {
        char[] array = value.ToCharArray();
        // Handle the first letter in the string.
        if (array.Length >= 1)
        {
            if (char.IsLower(array[0]))
            {
                array[0] = char.ToUpper(array[0]);
            }
        }
        // Scan through the letters, checking for spaces.
        // ... Uppercase the lowercase letters following spaces.
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i - 1] == ' ')
            {
                if (char.IsLower(array[i]))
                {
                    array[i] = char.ToUpper(array[i]);
                }
            }
            else 
            if (char.IsUpper(array[i]))
            {
                array[i] = char.ToLower(array[i]);
            }
        }

        return new string(array);
    }

    static void Main()
    {
        // Uppercase words in these strings.
        Console.WriteLine("Ivesk varda ir pavarde");
        string value1 = Console.ReadLine();
        Console.WriteLine("Ivestas vardas ir pavarde: " + value1);

        // ... Compute the uppercase strings.
        Console.WriteLine("Sukonvertuotas vardas ir pavarde: ");
        Console.WriteLine(UppercaseWords(value1));

        Console.ReadKey();

    }
}