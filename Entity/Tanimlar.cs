using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FiloKiralama.Entity
{
    public class Tanimlar
    {
        public enum SigortaTur
        {
            Sigorta = 1,
            Kasko = 2
        }

        public enum VergiDonem
        {
            Ocak = 1,
            Temmuz = 2
        }

        public enum DovizKur
        {
            TL = 1,
            Dolar = 2,
            Euro = 3
        }
    }
}
