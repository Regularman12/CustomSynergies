using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NoPseudosynergies
{
    class CustomSynergiesCel
    {
        public class ExtravaganceSynergy : AdvancedSynergyEntry
        {
            public ExtravaganceSynergy()
            {
                this.NameKey = "Extravagance";
                this.MandatoryItemIDs = new List<int>
                {
                    ETGMod.Databases.Items["Auric Vial"].PickupObjectId,
                    532
                };
                this.IgnoreLichEyeBullets = true;
                this.statModifiers = new List<StatModifier>(0);
                this.bonusSynergies = new List<CustomSynergyType>();
            }
        }

        public class RulebookSynergy : AdvancedSynergyEntry
        {
            public RulebookSynergy()
            {
                this.NameKey = "Rulebook";
                this.MandatoryItemIDs = new List<int>
                {
                    ETGMod.Databases.Items["Mininomocon"].PickupObjectId,
                    521
                };
                this.IgnoreLichEyeBullets = true;
                this.statModifiers = new List<StatModifier>(0);
                this.bonusSynergies = new List<CustomSynergyType>();
            }
        }
    }
}
