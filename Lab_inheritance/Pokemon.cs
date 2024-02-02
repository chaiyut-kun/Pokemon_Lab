using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_inheritance
{
    public enum PokemonType
    {
        Poison, Electr, Water,
    }

    public enum PokemonAbilities
    {
        Poison_Point, Rivalry, Hustle, Torrent_Rain_Dish, Static_Lightning_Rod
    }

    public class Pokemon
    {
        protected int id;
        protected string name;
        protected Image picture;
        protected int level;
        protected PokemonType type;
        protected PokemonAbilities abilities;
        protected int speed, hp, att, def, sAtt, sDef;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public Image Picture { get => picture; set => picture = value; }
        public int Level { get => level; set => level = value; }
        public PokemonType Type { get => type; set => type = value; }
        public PokemonAbilities Abilities { get => abilities; set => abilities = value; }
        
        public Pokemon() { }
    }
}
