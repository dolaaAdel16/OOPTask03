﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Tom : ICartoonCharacter
    {
        public string Name { get; set; } = "Tom"; 

        public void ShowTalent()
        {
            Console.WriteLine($"Hi , I'm {Name}");

            Console.WriteLine("My Talent , I chase Jerry all day...and My own traps . it's a skill!");

            Console.WriteLine(); 

        }
    }
}
