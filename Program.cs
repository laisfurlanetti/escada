﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace escada
{
    class Program
    {
        static void Main(string[] args)
        {
            string p1;
            int tamanho;

            Console.Write("Escreva uma palavra: ");
            p1 = Console.ReadLine().ToUpper();
            tamanho = p1.Length;
            
            for (int i = 0; i <= tamanho; i++)
                Console.WriteLine(p1.Substring(0, i));

            for (int i = 0; i <= tamanho; i++)
                Console.WriteLine(p1.Substring(i));

            Console.ReadLine();
                
           
        }

    }
}
