﻿using System;
using System.Diagnostics;

namespace SingleResponsibility
{
    class Program
    {
        static void Main()
        {
            var journal = new Journal();
            journal.AddEntry("I was stressed today");
            journal.AddEntry("I was found today");

            Console.WriteLine(journal);

            var p = new Persistence();
            var filename = @"C:\Projects\journal.txt";

            p.SaveToFile(journal,filename,true);
            Process.Start(filename);
        }
    }
}
