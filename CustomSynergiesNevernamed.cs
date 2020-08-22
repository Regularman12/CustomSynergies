using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NoPseudosynergies
{
    class CustomSynergiesNevernamed
    {
        public class LewisBattleStand : AdvancedSynergyEntry
        {
            public LewisBattleStand()
            {
                this.NameKey = "Will+";
                this.MandatoryItemIDs = new List<int>
                {
                    ETGMod.Databases.Items["Lewis"].PickupObjectId,
                    529
                };
                this.IgnoreLichEyeBullets = true;
                this.statModifiers = new List<StatModifier>(0);
                this.bonusSynergies = new List<CustomSynergyType>();
            }
        }

        public class DiscountsGoodSynergy : AdvancedSynergyEntry
        {
            public DiscountsGoodSynergy()
            {
                this.NameKey = "Discounts = Good";
                this.MandatoryItemIDs = new List<int>
                {
                    ETGMod.Databases.Items["Coupon"].PickupObjectId,
                    132
                };
                this.IgnoreLichEyeBullets = true;
                this.statModifiers = new List<StatModifier>(0);
                this.bonusSynergies = new List<CustomSynergyType>();
            }
        }

        public class CharmChamberSynergy : AdvancedSynergyEntry
        {
            public CharmChamberSynergy()
            {
                this.NameKey = "The Charmber";
                this.MandatoryItemIDs = new List<int>
                {
                    ETGMod.Databases.Items["Flame Chamber"].PickupObjectId,
                };
                this.OptionalItemIDs = new List<int>
                {
                    527,
                    200,
                    206
                };
                this.IgnoreLichEyeBullets = true;
                this.statModifiers = new List<StatModifier>(0);
                this.bonusSynergies = new List<CustomSynergyType>();
            }
        }

        public class LocketPadlock : AdvancedSynergyEntry
        {
            public LocketPadlock()
            {
                this.NameKey = "Locket Padlock";
                this.MandatoryItemIDs = new List<int>
                {
                    ETGMod.Databases.Items["Heart Padlock"].PickupObjectId,
                    423
                };
                this.IgnoreLichEyeBullets = true;
                this.statModifiers = new List<StatModifier>(0);
                this.bonusSynergies = new List<CustomSynergyType>();
            }
        }

        public class UnlockedPadlock : AdvancedSynergyEntry
        {
            public UnlockedPadlock()
            {
                this.NameKey = "Unlocked Padlock";
                this.MandatoryItemIDs = new List<int>
                {
                    ETGMod.Databases.Items["Heart Padlock"].PickupObjectId,
                    166
                };
                this.IgnoreLichEyeBullets = true;
                this.statModifiers = new List<StatModifier>(0);
                this.bonusSynergies = new List<CustomSynergyType>();
            }
        }

        public class VeryExplosiveCharacter : AdvancedSynergyEntry
        {
            public VeryExplosiveCharacter()
            {
                this.NameKey = "Very Explosive Character";
                this.MandatoryItemIDs = new List<int>
                {
                    ETGMod.Databases.Items["Nitro Bullets"].PickupObjectId,
                    304
                };
                this.IgnoreLichEyeBullets = true;
                this.statModifiers = new List<StatModifier>(0);
                this.bonusSynergies = new List<CustomSynergyType>();
            }
        }

        public class HiddenTechHasteSynergy : AdvancedSynergyEntry
        {
            public HiddenTechHasteSynergy()
            {
                this.NameKey = "Table Tech Haste";
                this.MandatoryItemIDs = new List<int>
                {
                    ETGMod.Databases.Items["Table Tech Speed"].PickupObjectId,
                    ETGMod.Databases.Items["Speed Potion"].PickupObjectId
                };
                this.IgnoreLichEyeBullets = true;
                this.statModifiers = new List<StatModifier>(0);
                this.bonusSynergies = new List<CustomSynergyType>();
            }
        }

        public class SpheresTooSynergy : AdvancedSynergyEntry
        {
            public SpheresTooSynergy()
            {
                this.NameKey = "Yeah, Spheres Too";
                this.MandatoryItemIDs = new List<int>
                {
                    ETGMod.Databases.Items["Miners Bullets"].PickupObjectId,
                    190
                };
                this.IgnoreLichEyeBullets = true;
                this.statModifiers = new List<StatModifier>(0);
                this.bonusSynergies = new List<CustomSynergyType>();
            }
        }

        public class CubeOfSpaceMetalSynergy: AdvancedSynergyEntry
        {
            public CubeOfSpaceMetalSynergy()
            {
                this.NameKey = "Cube of Space Metal";
                this.MandatoryItemIDs = new List<int>
                {
                    ETGMod.Databases.Items["Miners Bullets"].PickupObjectId,
                    ETGMod.Databases.Items["Lump of Space Metal"].PickupObjectId
                };
                this.IgnoreLichEyeBullets = true;
                this.statModifiers = new List<StatModifier>(0);
                this.bonusSynergies = new List<CustomSynergyType>();
            }
        }
    }
}
