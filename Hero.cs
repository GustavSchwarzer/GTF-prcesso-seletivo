using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasDio
{
    public class Hero
    {
        public string Name { get; set; }
        public string Style { get; set; }
        public int HP { get; set; }
        public int Level { get; set; }
        public int MP { get; set; }
        public string Resp { get; set; }

       public Hero(){
            
            }
        public Hero(string name,int level, string style,int hP,   int mP)
        {
            Name=name;
            Style=style;
            HP=hP;
            Level=level;
            MP=mP;
        }

        public override string ToString()
        {
            return Style +" "+ Name + " of level " + Level + " " ;
        }

     


    }
}
