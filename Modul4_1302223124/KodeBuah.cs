using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4_1302223124
{
    internal class KodeBuah
    {
        public enum buah
        {
            Apel,
            Aprikot,
            Alpukat,
            Pisang,
            Paprika,
            Blackberry,
            Ceri,
            Kelapa,
            Jagung,
            Kurma,
            Durian,
            Anggur,
            Melon,
            Semangka,
        }
        public static String getcodebuah(buah code)
        {
            String[] kode = {"A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00" , "J00" , "K00" , "L00" , "Ooo" }
            return kode[(int)code];
        }
    }
}
