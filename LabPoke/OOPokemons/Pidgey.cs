using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LabPoke.Pokemon
{

    public class Pidgey : Pokemons
    {
        public Pidgey()
        {

            this.name = "Pidgey";
            Random random = new Random();
            //random number between >= 200 and <295
            this.HP = random.Next(275, 368);
            this._image = Properties.Resources.pidgey1;
            this.Attack = random.Next(119, 248);
            this.Defense = random.Next(115, 287);
        }
    }
}