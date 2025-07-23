using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> emailSubjects = new List<string> // 1 
        {
            "New Lead from Form",
            "Daily Report",
            "Zoom Invite",
            "Cybersecurity Lead"
        };

        Console.WriteLine("Filtered Email Subjects (containing 'Lead'):\n"); // 2

        foreach (string subject in emailSubjects)
        {
            if (ContainsWordLead(subject))//3
            {
                Console.WriteLine(subject);//16
            }
        }
    }

    // Manual case-insensitive search for the word "lead"
    static bool ContainsWordLead(string text)//4
    {
        char[] target = { 'l', 'e', 'a', 'd' }; // target word "lead" Case Senstive

        for (int i = 0; i <= text.Length - 4; i++)//5
        {
            if (IsMatch(text, i, target))//6
            {
                return true;//15
            }
        }

        return false;
    }

    // Manual checking  match checking ignoring case
    static bool IsMatch(string text, int index, char[] target)//7
    {
        for (int j = 0; j < target.Length; j++)//8
        {
            char textChar = text[index + j];
            char targetChar = target[j];

            if (!CharEqualsIgnoreCase(textChar, targetChar))//9
            {
                return false;
            }
        }
        return true;//14
    }

    // Compare characters ignoring case
    static bool 
        
        
        CharEqualsIgnoreCase(char a, char b)//10
    {
        if (a >= 'A' && a <= 'Z')//11
            a = (char)(a + 32); // convert to lowercase

        if (b >= 'A' && b <= 'Z')//12
            b = (char)(b + 32); // convert to lowercase

        return a == b;//13
    }
}
