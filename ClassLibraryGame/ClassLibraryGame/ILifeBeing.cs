using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryGame
{
    public interface ILifeBeing
    {
        int health { get; set; }
        int attack { get; set; }
        string photoPath { get; set; }
        int heal { get; set; }
    }
}
