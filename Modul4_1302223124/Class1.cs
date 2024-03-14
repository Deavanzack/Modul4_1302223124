using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4_1302223124
{
    enum state { jongkok, berdiri, tengkurap, terbang }
    internal class PosisiKarakterGame
    {
        private state kondisi;

        public PosisiKarakterGame()
        {
            kondisi = state.berdiri;
            Console.WriteLine("berdiri");
        }

        public void posisikar()
        {
           if (kondisi == state.berdiri)
            {
                Console.WriteLine("Posisi Standby");
            } else if (kondisi == state.tengkurap)
            {
                Console.WriteLine("posisi istirahat");
            }
        }
    }
}
