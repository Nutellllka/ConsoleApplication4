namespace ConsoleApplication4
{
    using System;
    using System.Collections.Generic;
    
    internal class Program
    {
        public static void Main(string [] args)
        {
            Console.WriteLine("1 Завдання");
            List<string> rowsofverse = new List<string>();
          
            rowsofverse.Add("Little leaves fall softly down");
            rowsofverse.Add("Red and yellow, orange and brown");
            rowsofverse.Add("Whirling, twirling round and round");
            rowsofverse.Add("Falling softly to the ground");
            rowsofverse.Add("Little leaves fall softly down");
            rowsofverse.Add("To make a carpet on the ground");
            rowsofverse.Add("Then, swish, the wind comes whistling by");
            rowsofverse.Add("And sends them dancing to the sky");
          
            rowsofverse.Sort((x, y) => x.Length.CompareTo(y.Length)) ;
          
            foreach (var rows in rowsofverse)
            {
                Console.WriteLine(rows);
            }
        } 
    }
}