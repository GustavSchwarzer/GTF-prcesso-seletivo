using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasDio
{
    internal class Topapa : Hero
    {

        public Topapa(string name, int level, string style, int hP, int mP) : base(name, level, style, hP, mP)
        {
        }

        public virtual string Atack()
        {
            return Name + "Fez um sacrifício para te deixar encantado por borboletas ('@_@')";
        }
    }
}
