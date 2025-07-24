using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface ICartoonCharacter
    {
        string Name { get; set; }
        void ShowTalent(); 
    }
}
