using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_inheritance
{
    public class Pikachu : Pokemon
    {
        public Pikachu()
        {

            name = "Pikachu";
            id = 25;
            level = 1;
            type = PokemonType.Electr;
            picture = Properties.Resources.Pikachu;
        }

    }

    class Squirtle : Pokemon
    {
        public Squirtle()
        {
            name = "Squirtle";
            id = 7;
            level = 1;
            type = PokemonType.Water;
            picture = Properties.Resources.Squirtle;
        }
    }
    public class Wartortle : Pokemon
    {
        public Wartortle()
        {
            name = "Wartortle";
            id = 8;
            level = 1;
            type = PokemonType.Water;
            picture = Properties.Resources.Wartortle;
        }
    }

    public class Blastoise : Pokemon
    {
        public Blastoise()
        {
            name = "Blastoise";
            id = 9;
            level = 1;
            type = PokemonType.Water;
            picture = Properties.Resources.Blastoise;
        }
    }

    public class Raichu : Pokemon
    {
        public Raichu()
        {
            name = "Raichu";
            id = 26;
            level = 1;
            type = PokemonType.Electr;
            picture = Properties.Resources.Raichu;
        }
    }

    class Nidorina : Pokemon
    {
        public Nidorina()
        {
            name = "Nidorina";
            id = 30;
            level = 1;
            type = PokemonType.Poison;
            picture = Properties.Resources.Nidorina;
        }
    }
}
