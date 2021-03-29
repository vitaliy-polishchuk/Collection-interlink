using System.Collections.Generic;
using System;

namespace EmployeeBirthdays
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> WordFrequency = new Dictionary<string, int>();

            string text = "Structured Text is PLC programming language defined by PLCOpen in IEC 61131-3. The programming language is text-based, compared to the graphics-based ladder diagram or Function Block Diagram. At first, it may seem better to use a graphical programming language for PLC programming. But in my opinion, that is only true for smaller PLC programs.By using a text-based PLC programming language, your program will take up much smaller space, and the flow/ logic will be easier to read and understand.You";

            string[] words = text.Split(' ');

            foreach (var word in words)
            {
                if (WordFrequency.ContainsKey(word))
                {
                    int value = WordFrequency[word];
                    value++;
                    WordFrequency[word] = value;
                }
                else
                {
                    WordFrequency.Add(word, 1);
                }
            }

            foreach (KeyValuePair<string, int> keyValue in WordFrequency)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }

            ///////////////////////////////////////////

            Employee vasya = new Employee();

            vasya.name = "Vasya";
            vasya.birthDateYear = 1992;

            Employee petya = new Employee();

            petya.name = "Petya";
            petya.birthDateYear = 1990;

            Employee[] employees = { vasya, petya };
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.name);
            }

        }
    }
}
