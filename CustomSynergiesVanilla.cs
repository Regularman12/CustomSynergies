using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NoPseudosynergies
{
    class CustomSynergiesVanilla
    {
        public class HeroOfChicken : AdvancedSynergyEntry
        {
            public HeroOfChicken()
            {
                this.NameKey = "Chicken Sword";
                this.MandatoryItemIDs = new List<int>
                {
                    572
                };
                this.MandatoryGunIDs = new List<int>
                {
                    417
                };
                this.IgnoreLichEyeBullets = false;
                this.ActiveWhenGunUnequipped = false;
                this.statModifiers = new List<StatModifier>(0);
                this.bonusSynergies = new List<CustomSynergyType>
                {
                    CustomSynergyType.HERO_OF_CHICKEN
                };
            }
        }
    }
}
