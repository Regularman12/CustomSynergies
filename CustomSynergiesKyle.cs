using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CustomItems;
using UnityEngine;

namespace NoPseudosynergies
{
    class CustomSynergiesKyle
    {
        public class BestConstructorSynergy : AdvancedSynergyEntry
        {
            public BestConstructorSynergy()
            {
                this.NameKey = "Goopy Gungeoneers";
                this.MandatoryItemIDs = new List<int>
                {
                    ETGMod.Databases.Items["Baby Good Blob"].PickupObjectId,
                };
                this.OptionalItemIDs = new List<int>
                {
                    205,
                    313,
                    159
                };
                this.IgnoreLichEyeBullets = true;
                this.statModifiers = new List<StatModifier>(0);
                this.bonusSynergies = new List<CustomSynergyType>();
            }
        }

        public class GoopyGungeonSynergyController : MonoBehaviour
        {
            private void Awake()
            {
                this.bgb = base.GetComponent<PassiveItem>();
                this.owner = this.bgb.Owner;
            }

            private void Update()
            {

            }

            private bool hasSynergyLast;
            private DamageTypeModifier elecImmunity;
            private DamageTypeModifier fireImmunity;
            private DamageTypeModifier poisonImmunity;
            private PlayerController owner;
            private PassiveItem bgb;
        }

        class SynergyHooks
        {
            
        }
    }
}
