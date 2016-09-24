using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FiloKiralama.Entity
{
    public class Media
    {
        public int Id { get; set; }
        public int Category { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Desc { get; set; }
    }
}
