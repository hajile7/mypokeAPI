﻿namespace PokeAPI.Models
{
    public class Sprites
    {
        public string back_default { get; set; }
        public object back_female { get; set; }
        public string back_shiny { get; set; }
        public object back_shiny_female { get; set; }
        public string front_default { get; set; }
        public object front_female { get; set; }
        public string front_shiny { get; set; }
        public object front_shiny_female { get; set; }
        public Other? other { get; set; }
        public Versions? versions { get; set; }
    }
    public class Other
    {
        public Dream_World? dream_world { get; set; }
        public Home? home { get; set; }
        public OfficialArtwork? officialartwork { get; set; }
        public Showdown? showdown { get; set; }
    }

    public class Dream_World
    {
        public string front_default { get; set; }
        public object front_female { get; set; }
    }

    public class Home
    {
        public string front_default { get; set; }
        public object front_female { get; set; }
        public string front_shiny { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class OfficialArtwork
    {
        public string front_default { get; set; }
        public string front_shiny { get; set; }
    }

    public class Showdown
    {
        public string back_default { get; set; }
        public object back_female { get; set; }
        public string back_shiny { get; set; }
        public object back_shiny_female { get; set; }
        public string front_default { get; set; }
        public object front_female { get; set; }
        public string front_shiny { get; set; }
        public object front_shiny_female { get; set; }
    }
    public class Versions
    {
        public GenerationI generationi { get; set; }
        public GenerationIi generationii { get; set; }
        public GenerationIii generationiii { get; set; }
        public GenerationIv generationiv { get; set; }
        public GenerationV generationv { get; set; }
        public GenerationVi generationvi { get; set; }
        public GenerationVii generationvii { get; set; }
        public GenerationViii generationviii { get; set; }
    }

    public class GenerationI
    {
        public RedBlue redblue { get; set; }
        public Yellow yellow { get; set; }
    }

    public class RedBlue
    {
        public string back_default { get; set; }
        public string back_gray { get; set; }
        public string back_transparent { get; set; }
        public string front_default { get; set; }
        public string front_gray { get; set; }
        public string front_transparent { get; set; }
    }

    public class Yellow
    {
        public string back_default { get; set; }
        public string back_gray { get; set; }
        public string back_transparent { get; set; }
        public string front_default { get; set; }
        public string front_gray { get; set; }
        public string front_transparent { get; set; }
    }

    public class GenerationIi
    {
        public Crystal crystal { get; set; }
        public Gold gold { get; set; }
        public Silver silver { get; set; }
    }

    public class Crystal
    {
        public string back_default { get; set; }
        public string back_shiny { get; set; }
        public string back_shiny_transparent { get; set; }
        public string back_transparent { get; set; }
        public string front_default { get; set; }
        public string front_shiny { get; set; }
        public string front_shiny_transparent { get; set; }
        public string front_transparent { get; set; }
    }

    public class Gold
    {
        public string back_default { get; set; }
        public string back_shiny { get; set; }
        public string front_default { get; set; }
        public string front_shiny { get; set; }
        public string front_transparent { get; set; }
    }

    public class Silver
    {
        public string back_default { get; set; }
        public string back_shiny { get; set; }
        public string front_default { get; set; }
        public string front_shiny { get; set; }
        public string front_transparent { get; set; }
    }

    public class GenerationIii
    {
        public Emerald emerald { get; set; }
        public FireredLeafgreen fireredleafgreen { get; set; }
        public RubySapphire rubysapphire { get; set; }
    }

    public class Emerald
    {
        public string front_default { get; set; }
        public string front_shiny { get; set; }
    }

    public class FireredLeafgreen
    {
        public string back_default { get; set; }
        public string back_shiny { get; set; }
        public string front_default { get; set; }
        public string front_shiny { get; set; }
    }

    public class RubySapphire
    {
        public string back_default { get; set; }
        public string back_shiny { get; set; }
        public string front_default { get; set; }
        public string front_shiny { get; set; }
    }

    public class GenerationIv
    {
        public DiamondPearl diamondpearl { get; set; }
        public HeartgoldSoulsilver heartgoldsoulsilver { get; set; }
        public Platinum platinum { get; set; }
    }

    public class DiamondPearl
    {
        public string back_default { get; set; }
        public object back_female { get; set; }
        public string back_shiny { get; set; }
        public object back_shiny_female { get; set; }
        public string front_default { get; set; }
        public object front_female { get; set; }
        public string front_shiny { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class HeartgoldSoulsilver
    {
        public string back_default { get; set; }
        public object back_female { get; set; }
        public string back_shiny { get; set; }
        public object back_shiny_female { get; set; }
        public string front_default { get; set; }
        public object front_female { get; set; }
        public string front_shiny { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class Platinum
    {
        public string back_default { get; set; }
        public object back_female { get; set; }
        public string back_shiny { get; set; }
        public object back_shiny_female { get; set; }
        public string front_default { get; set; }
        public object front_female { get; set; }
        public string front_shiny { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class GenerationV
    {
        public BlackWhite blackwhite { get; set; }
    }

    public class BlackWhite
    {
        public Animated animated { get; set; }
        public string back_default { get; set; }
        public object back_female { get; set; }
        public string back_shiny { get; set; }
        public object back_shiny_female { get; set; }
        public string front_default { get; set; }
        public object front_female { get; set; }
        public string front_shiny { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class Animated
    {
        public string back_default { get; set; }
        public object back_female { get; set; }
        public string back_shiny { get; set; }
        public object back_shiny_female { get; set; }
        public string front_default { get; set; }
        public object front_female { get; set; }
        public string front_shiny { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class GenerationVi
    {
        public OmegarubyAlphasapphire omegarubyalphasapphire { get; set; }
        public XY xy { get; set; }
    }

    public class OmegarubyAlphasapphire
    {
        public string front_default { get; set; }
        public object front_female { get; set; }
        public string front_shiny { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class XY
    {
        public string front_default { get; set; }
        public object front_female { get; set; }
        public string front_shiny { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class GenerationVii
    {
        public Icons icons { get; set; }
        public UltraSunUltraMoon ultrasunultramoon { get; set; }
    }

    public class Icons
    {
        public string front_default { get; set; }
        public object front_female { get; set; }
    }

    public class UltraSunUltraMoon
    {
        public string front_default { get; set; }
        public object front_female { get; set; }
        public string front_shiny { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class GenerationViii
    {
        public Icons1 icons { get; set; }
    }

    public class Icons1
    {
        public string front_default { get; set; }
        public object front_female { get; set; }
    }
}
