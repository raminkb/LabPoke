using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPoke.Pokemon
{
    public class Poliwag : Pokemons
    {
        public Poliwag()
        {

            this.name = "Poliwag";
            Random random = new Random();
            //random number between >= 200 and <295
            this.HP = random.Next(270, 364);
            this._image = Properties.Resources.Poliwag1;
            this.Attack = random.Next(100, 200);
            this.Defense = random.Next(110, 240);
        }
    }
}
