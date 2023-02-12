using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPoke.Pokemon
{
    public class Squirtle : Pokemons
    {
        public Squirtle()
        {

            this.name = "Squirtle";
            Random random = new Random();
            //random number between >= 200 and <295
            this.HP = random.Next(200, 360);
            this._image = Properties.Resources.Squirtle1;
            this.Attack = random.Next(126, 235);
            this.Defense = random.Next(147, 267);
        }
    }
}
