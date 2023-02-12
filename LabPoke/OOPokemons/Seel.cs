using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPoke.Pokemon
{
    public class Seel : Pokemons
    {
        public Seel()
        {

            this.name = "Seel";
            Random random = new Random();
            //random number between >= 200 and <295
            this.HP = random.Next(275, 360);
            this._image = Properties.Resources.Seel1;
            this.Attack = random.Next(106, 205);
            this.Defense = random.Next(107, 207);
        }
    }
}
