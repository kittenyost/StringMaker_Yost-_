// See https://aka.ms/new-console-template for more information
using StringMaker_Yost;

StringManager sm = new StringManager();
Console.WriteLine($"Reversed: {sm.Reverse("Sunbeam Tiger")}");
Console.WriteLine($"ToString: {sm.ToString()}");
Console.WriteLine($"Reversed Preserve Case: {sm.Reverse("Sunbeam Tiger", true)}");
Console.WriteLine($"Equals: {sm.Equals("Sunbeam Tiger")}");
Console.WriteLine($"Symmetric: {sm.Symmetric("ABBA")}");
Console.WriteLine($"Symmetric: {sm.Symmetric("ABA")}");
Console.WriteLine($"Symmetric: {sm.Symmetric("ABba")}");