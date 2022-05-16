using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasDio
{
    public class Arus : Hero
    {
        public Arus(string name, int level, string style, int hP, int mP) : base(name, level, style, hP, mP)
        {
        }

        public virtual string Atack()
        {
            return Name + " Atacou com a espada!!!";
        }
    }
}
