using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA200324B
{
    class Ar
    {
        public DateTime Valtozas { get; set; }
        public int Benzin { get; set; }
        public int Gazolja { get; set; }
        public int Diferencial => Math.Abs(Benzin - Gazolja);
        public bool Szokonap => 
            DateTime.IsLeapYear(Valtozas.Year) 
            && Valtozas.Month == 2 
            && Valtozas.Day == 24;
    }
}
