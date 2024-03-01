using System;

namespace PokeAPI.Models
{
    public partial class PokemonModel
    {
        public Ability[] abilities { get; set; }
        public int base_experience { get; set; }
        public Form[] forms { get; set; }
        public Game_Indices[] game_indices { get; set; }
        public int height { get; set; }
        public Held_Items[] held_items { get; set; }
        public int id { get; set; }
        public bool is_default { get; set; }
        public string location_area_encounters { get; set; }
        public Move[] moves { get; set; }
        public string name { get; set; }
        public int order { get; set; }
        public Past_Abilities[] past_abilities { get; set; }
        public object[] past_types { get; set; }
        public Species species { get; set; }
        public Sprites sprites { get; set; }
        public Stat[] stats { get; set; }
        public Type[] types { get; set; }
        public int weight { get; set; }
    }
    //I don't really use the vars below here quite yet.
    //Sprites class holds all its dependent classes (quite a few)
    public class Species
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Form
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Game_Indices
    {
        public int game_index { get; set; }
        public Version version { get; set; }
    }

    public class Version
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Held_Items
    {
        public Item item { get; set; }
        public Version_Details[] version_details { get; set; }
    }

    public class Item
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Version_Details
    {
        public int rarity { get; set; }
        public Version1 version { get; set; }
    }

    public class Version1
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Move
    {
        public Move1 move { get; set; }
        public Version_Group_Details[] version_group_details { get; set; }
    }

    public class Move1
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Version_Group_Details
    {
        public int level_learned_at { get; set; }
        public Move_Learn_Method move_learn_method { get; set; }
        public Version_Group version_group { get; set; }
    }

    public class Move_Learn_Method
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Version_Group
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Past_Abilities
    {
        public Ability2[] abilities { get; set; }
        public Generation generation { get; set; }
    }

    public class Generation
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Ability2
    {
        public Ability3 ability { get; set; }
        public bool is_hidden { get; set; }
        public int slot { get; set; }
    }

    public class Ability3
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Stat
    {
        public int base_stat { get; set; }
        public int effort { get; set; }
        public Stat1 stat { get; set; }
    }

    public class Stat1
    {
        public string name { get; set; }
        public string url { get; set; }

    }
}