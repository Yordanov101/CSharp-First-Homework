﻿using System;
class AgeAfterTenYears
{
    // Program to read your birthday from the console and print how old you are now and after 10 years.
    static void Main()
    {
        Console.WriteLine("Please enter your date of birth in format DD MM YYYY:");
        DateTime birthday = DateTime.Parse(Console.ReadLine());
        DateTime today = DateTime.Now;

        int age = today.Year - birthday.Year;

        if (today.Month < birthday.Month)
        {
            age--;
        }

        else if (birthday.Month == today.Month && today.Day < birthday.Day)
        {
            age--;
        }
        Console.WriteLine("You are now {0} years old.", age);
        DateTime dateIn10Years = today.AddYears(10);
        int ageIn10Years = dateIn10Years.Year - birthday.Year;
        if (dateIn10Years.Month < birthday.Month)
        {
            ageIn10Years--;
        }

        else if (birthday.Month == dateIn10Years.Month && dateIn10Years.Day < birthday.Day)
        {
            ageIn10Years--;
        }
        Console.WriteLine("After 10 years you will be {0} years old.", ageIn10Years);
    }
}