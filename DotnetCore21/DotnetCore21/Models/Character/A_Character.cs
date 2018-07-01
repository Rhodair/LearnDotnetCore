using DotnetCore21.Models.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetCore21.Models.Character
{
    public class A_Character : Asset
    {
        public int Race { get; set; }
        // Being more masculine or feminine shifts the character's values
        public int Masculinity { get; set; }    // Values power
        public int Femininity { get; set; }     // Comes from a place of virtue
        public int Fitness { get; set; }        // Musculature
        public int Fatness { get; set; }        // Thickness
        // Core Stats
        public int Agility { get; set; }        // AGI: Dexterity and speed
        public int Strength { get; set; }       // STR: Ability to weild grander weapons and strike with greater efficiency
        public int Vitality { get; set; }       // VIT: Toughness and resilience
        public int Intelligence { get; set; }   // INT: Boosts attack of spells and ability to cast more effectively
        public int Willpower { get; set; }      // WIL: Increases mana capacity and regen
        public int Luck { get; set; }           // LUK: Effects everything nominally

        public IList<Head> Heads { get; set; }
        public IList<Core> Core { get; set; }
        public IList<Shoulder> Shoulders { get; set; }
        public IList<Arm> Arms { get; set; }
        public IList<Hand> Hands { get; set; }
        public IList<Waist> Waist { get; set; }
        public IList<Leg> Legs { get; set; }
        public IList<Foot> Feet { get; set; }

        public IList<A_Item> Equipment { get; set; }
        public IList<A_Item> Inventory { get; set; }
    }
}
