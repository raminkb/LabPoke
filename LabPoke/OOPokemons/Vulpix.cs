using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPoke.Pokemon
{
    public class Vulpix : Pokemons
    {
        public Vulpix()
        {

            this.name = "Vulpix";
            Random random = new Random();
            //random number between >= 200 and <295
            this.HP = random.Next(276, 304);
            this._image = Properties.Resources.Vulpix1;
            this.Attack = random.Next(186, 245);
            this.Defense = random.Next(117, 249);
        }
    }
}
