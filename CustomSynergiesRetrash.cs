using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using Blunderbeast;
using UnityEngine;
using Dungeonator;

namespace NoPseudosynergies
{
    class CustomSynergiesRetrash
    {
        public class MysteriousBrewSynergy : AdvancedSynergyEntry
        {
            public MysteriousBrewSynergy()
            {
                this.NameKey = "Mysterious Brew";
                this.MandatoryItemIDs = new List<int>
                {
                    ETGMod.Databases.Items["Panacea"].PickupObjectId
                };
                this.OptionalItemIDs = new List<int>
                {
                    64,
                    174,
                    267,
                    168,
                    205,
                    427,
                    426,
                    424
                };
                this.IgnoreLichEyeBullets = true;
                this.statModifiers = new List<StatModifier>(0);
                this.bonusSynergies = new List<CustomSynergyType>();
            }
        }

        public class HiddenTechMurderSynergy : AdvancedSynergyEntry
        {
            public HiddenTechMurderSynergy()
            {
                this.NameKey = "Hidden Tech Assassin";
                this.MandatoryItemIDs = new List<int>
                {
                    ETGMod.Databases.Items["Table Tech Stealth"].PickupObjectId
                };
                this.OptionalItemIDs = new List<int>
                {
                    524,
                    436
                };
                this.IgnoreLichEyeBullets = true;
                this.statModifiers = new List<StatModifier>(0);
                this.bonusSynergies = new List<CustomSynergyType>();
            }
        }

        public class NotSoHarsh : AdvancedSynergyEntry
        {
            public NotSoHarsh()
            {
                this.NameKey = "Not So Harsh";
                this.MandatoryItemIDs = new List<int>
                {
                    ETGMod.Databases.Items["Unstable Dodgicite Ring"].PickupObjectId,
                    ETGMod.Databases.Items["Ring of Discipline"].PickupObjectId
                };
                this.IgnoreLichEyeBullets = true;
                this.statModifiers = new List<StatModifier>(0);
                this.bonusSynergies = new List<CustomSynergyType>();
            }
        }

        public class RecycloadedGoodiesSynergy : AdvancedSynergyEntry
        {
            public RecycloadedGoodiesSynergy()
            {
                this.NameKey = "Recycloaded Goodies";
                this.MandatoryItemIDs = new List<int>
                {
                    ETGMod.Databases.Items["Recycloader"].PickupObjectId,
                    116
                };
                this.IgnoreLichEyeBullets = true;
                this.statModifiers = new List<StatModifier>(0);
                this.bonusSynergies = new List<CustomSynergyType>();
            }
        }

        public class QualityMusicSynergy : AdvancedSynergyEntry
        {
            public QualityMusicSynergy()
            {
                this.NameKey = "Stunning Beat";
                this.MandatoryItemIDs = new List<int>
                {
                    ETGMod.Databases.Items["Boombox"].PickupObjectId,
                    119
                };
                this.IgnoreLichEyeBullets = true;
                this.statModifiers = new List<StatModifier>(0);
                this.bonusSynergies = new List<CustomSynergyType>();
            }
        }

        public class DoubleInfinitySynergy : AdvancedSynergyEntry
        {
            public DoubleInfinitySynergy()
            {
                this.NameKey = "Double Infinity";
                this.MandatoryItemIDs = new List<int>
                {
                    ETGMod.Databases.Items["Ouroboros"].PickupObjectId,
                    ETGMod.Databases.Items["Recycloader"].PickupObjectId
                };
                this.IgnoreLichEyeBullets = true;
                this.statModifiers = new List<StatModifier>(0);
                this.bonusSynergies = new List<CustomSynergyType>();
            }
        }

        public class FalseMusicantSynergy : AdvancedSynergyEntry
        {
            public FalseMusicantSynergy()
            {
                this.NameKey = "False Musician";
                this.MandatoryItemIDs = new List<int>
                {
                    ETGMod.Databases.Items["Charlatan's Crown"].PickupObjectId,
                    119
                };
                this.IgnoreLichEyeBullets = true;
                this.statModifiers = new List<StatModifier>
                {
                    new StatModifier()
                    {
                        statToBoost = PlayerStats.StatType.Damage,
                        modifyType = StatModifier.ModifyMethod.ADDITIVE,
                        amount = -0.3f
                    }
                };
                this.bonusSynergies = new List<CustomSynergyType>();
            }
        }

        public class SecondPartyControl : AdvancedSynergyEntry
        {
            public SecondPartyControl()
            {
                this.NameKey = "Second Party Control";
                this.MandatoryItemIDs = new List<int>
                {
                    ETGMod.Databases.Items["Mind Control Device"].PickupObjectId,
                };
                this.MandatoryGunIDs = new List<int>
                {
                    511
                };
                this.IgnoreLichEyeBullets = true;
                this.statModifiers = new List<StatModifier>(0);
                this.bonusSynergies = new List<CustomSynergyType>();
            }
        }

        public class SelfHarmSynergy : AdvancedSynergyEntry
        {
            public SelfHarmSynergy()
            {
                this.NameKey = "Self Harm";
                this.MandatoryItemIDs = new List<int>
                {
                    ETGMod.Databases.Items["Invoker"].PickupObjectId,
                    203
                };
                this.IgnoreLichEyeBullets = true;
                this.statModifiers = new List<StatModifier>(0);
                this.bonusSynergies = new List<CustomSynergyType>();
            }
        }

        public class ElementalShowerSynergy : AdvancedSynergyEntry
        {
            public ElementalShowerSynergy()
            {
                this.NameKey = "Elemental Shower";
                this.MandatoryItemIDs = new List<int>
                {
                    ETGMod.Databases.Items["Roshambo"].PickupObjectId,
                };
                this.OptionalItemIDs = new List<int>
                {
                    204,
                    295,
                    298
                };
                this.IgnoreLichEyeBullets = true;
                this.statModifiers = new List<StatModifier>(0);
                this.bonusSynergies = new List<CustomSynergyType>();
            }
        }

        public class FuriousThrowingSynergy : AdvancedSynergyEntry
        {
            public FuriousThrowingSynergy()
            {
                this.NameKey = "Furious Throwing";
                this.MandatoryItemIDs = new List<int>
                {
                    ETGMod.Databases.Items["Gravity Glove"].PickupObjectId,
                    440
                };
                this.IgnoreLichEyeBullets = true;
                this.statModifiers = new List<StatModifier>(0);
                this.bonusSynergies = new List<CustomSynergyType>();
            }
        }

        public class LeafDestructionSynergy : AdvancedSynergyEntry
        {
            public LeafDestructionSynergy()
            {
                this.NameKey = "2 Organic";
                this.MandatoryGunIDs = new List<int>
                {
                    ETGMod.Databases.Items["leafblower"].PickupObjectId,
                    339
                };
                this.IgnoreLichEyeBullets = false;
                this.statModifiers = new List<StatModifier>(0);
                this.bonusSynergies = new List<CustomSynergyType>();
            }
        }

        public class BestConstructorSynergy : AdvancedSynergyEntry
        {
            public BestConstructorSynergy()
            {
                this.NameKey = "Construction Master";
                this.MandatoryGunIDs = new List<int>
                {
                    ETGMod.Databases.Items["buildersbest"].PickupObjectId,
                };
                this.OptionalItemIDs = new List<int>
                {
                    66,
                    201,
                    644
                };
                this.IgnoreLichEyeBullets = false;
                this.statModifiers = new List<StatModifier>(0);
                this.bonusSynergies = new List<CustomSynergyType>();
            }
        }

        public class AlchemicalDischargeSynergy : AdvancedSynergyEntry
        {
            public AlchemicalDischargeSynergy()
            {
                this.NameKey = "Full Charge";
                this.MandatoryItemIDs = new List<int>
                {
                    ETGMod.Databases.Items["alchemiser"].PickupObjectId,
                };
                this.OptionalItemIDs = new List<int>
                {
                    64,
                    174
                };
                this.IgnoreLichEyeBullets = false;
                this.statModifiers = new List<StatModifier>(0);
                this.bonusSynergies = new List<CustomSynergyType>();
            }
        }

        public class FullChargeSynergyController : GunBehaviour
        {


            private void Update()
            {
                PlayerController player = this.gun.CurrentOwner as PlayerController;
                this.hasSynergy = player && (player.HasPickupID(64) || player.HasPickupID(174));
                if(this.hasSynergy != this.hasSynergyLast)
                {
                    if (this.hasSynergy)
                    {
                        if(this.m_poisonImmunity == null)
                        {
                            this.gun.TransformToTargetGun(ETGMod.Databases.Items["alche"] as Gun);
                            this.m_poisonImmunity = new DamageTypeModifier();
                            this.m_poisonImmunity.damageMultiplier = 0f;
                            this.m_poisonImmunity.damageType = CoreDamageTypes.Poison;
                            player.healthHaver.damageTypeModifiers.Add(this.m_poisonImmunity);
                        }
                    }
                    else
                    {
                        this.gun.TransformToTargetGun(ETGMod.Databases.Items["alchemiser"] as Gun);
                    }
                    this.hasSynergyLast = this.hasSynergy;
                }
                bool flag3 = !this.gun.IsReloading && !this.HasReloaded;
                if (flag3)
                {
                    this.HasReloaded = true;
                }
            }


            public override void OnReloadPressed(PlayerController player, Gun gun, bool bSOMETHING)
            {
                bool flag = gun.IsReloading && this.HasReloaded;
                if (flag)
                {
                    if (this.hasSynergy)
                    {
                        DeadlyDeadlyGoopManager.GetGoopManagerForGoopType(SynergyAlchemiser.goopDefs[0]).TimedAddGoopCircle(gun.sprite.WorldBottomCenter, 3.75f, 0.75f, false);
                    }
                }
                this.HasReloaded = false;
                base.OnReloadPressed(player, gun, bSOMETHING);
            }

            private bool hasSynergy = false;
            private bool hasSynergyLast = false;
            private DamageTypeModifier m_poisonImmunity = null;
            private bool HasReloaded = false;
        }

        public class ElementalShowerSynergyController : MonoBehaviour
        {
            private void Awake()
            {
                this.roshamboItem = base.GetComponent<Roshambo>();
            }

            private void Update()
            {
                List<int> OptionalItemIDs = new List<int>
                {
                    204,
                    295,
                    298
                };
                bool hasSynergy = false;
                foreach (PassiveItem passive in this.roshamboItem.Owner.passiveItems)
                {
                    if (OptionalItemIDs.Contains(passive.PickupObjectId))
                    {
                        hasSynergy = true;
                    }
                }
                if (this.roshamboItem.PickedUp && this.roshamboItem.Owner != null)
                {
                    if(this.roshamboItem.Owner.CurrentGun != null && this.roshamboItem.Owner.CurrentGun.IsReloading && hasSynergy)
                    {
                        this.roshamboItem.Owner.CurrentRoom.ApplyActionToNearbyEnemies(this.roshamboItem.Owner.CenterPosition, 5f, this.AuraAction);
                        this.HandleRadialIndicator();
                        if(this.radialIndicator != null)
                        {
                            if (this.roshamboItem.fireMode)
                            {
                                this.radialIndicator.CurrentColor = Color.red;
                                this.radialIndicator.IsFire = true;
                            }
                            else if (this.roshamboItem.poisonMode)
                            {
                                this.radialIndicator.CurrentColor = Color.green;
                                this.radialIndicator.IsFire = false;
                            }
                            else if (this.roshamboItem.electricMode)
                            {
                                this.radialIndicator.CurrentColor = Color.blue;
                                this.radialIndicator.IsFire = false;
                            }
                            this.radialIndicator.CurrentRadius = 5f;
                        }
                    }
                    else
                    {
                        this.UnhandleRadialIndicator();
                    }
                }
                else
                {
                    this.UnhandleRadialIndicator();
                }
            }

            private void AuraAction(AIActor aiactor, float d)
            {
                if (this.roshamboItem.fireMode)
                {
                    BulletStatusEffectItem f = (BulletStatusEffectItem)PickupObjectDatabase.GetById(295);
                    aiactor.ApplyEffect(f.FireModifierEffect, 1, null);
                }
                else if (this.roshamboItem.poisonMode)
                {
                    BulletStatusEffectItem f = (BulletStatusEffectItem)PickupObjectDatabase.GetById(204);
                    aiactor.ApplyEffect(f.HealthModifierEffect, 1, null);
                }
                else if (this.roshamboItem.electricMode)
                {
                    aiactor.healthHaver.ApplyDamage(0.45f, Vector2.zero, "Electricity", CoreDamageTypes.Electric, DamageCategory.Normal, false, null, false);
                }
            }

            private void HandleRadialIndicator()
            {
                if (!this.radialIndicatorActive)
                {
                    this.radialIndicatorActive = true;
                    this.radialIndicator = ((GameObject)UnityEngine.Object.Instantiate(ResourceCache.Acquire("Global VFX/HeatIndicator"), this.roshamboItem.Owner.CenterPosition.ToVector3ZisY(0f),
                        Quaternion.identity, this.roshamboItem.Owner.transform)).GetComponent<HeatIndicatorController>();
                    if (!this.roshamboItem.fireMode)
                    {
                        this.radialIndicator.CurrentColor = new Color(0f, 0f, 1f);
                        this.radialIndicator.IsFire = false;
                    }
                }
            }

            private void UnhandleRadialIndicator()
            {
                if (this.radialIndicatorActive)
                {
                    this.radialIndicatorActive = false;
                    if (this.radialIndicator)
                    {
                        this.radialIndicator.EndEffect();
                    }
                    this.radialIndicator = null;
                }
            }

            public Roshambo roshamboItem;
            public bool radialIndicatorActive;
            public HeatIndicatorController radialIndicator;
        }

        public class FuriousThrowingSynergyController : MonoBehaviour
        {
            private void Awake()
            {
                proj = base.GetComponent<Projectile>();
                this.radialIndicatorActive = true;
                this.radialIndicator = ((GameObject)UnityEngine.Object.Instantiate(ResourceCache.Acquire("Global VFX/HeatIndicator"), this.proj.sprite.WorldCenter.ToVector3ZisY(0f),
                    Quaternion.identity, this.proj.transform)).GetComponent<HeatIndicatorController>();
                this.proj.OnBecameDebris += this.CancelFire;
            }

            private void Update()
            {
                if (this.radialIndicatorActive && this.radialIndicator != null)
                {
                    this.radialIndicator.CurrentRadius = 5f;
                    RoomHandler absoluteRoom = this.proj.sprite.WorldCenter.GetAbsoluteRoom();
                    absoluteRoom.ApplyActionToNearbyEnemies(this.proj.sprite.WorldCenter, 5f, this.AuraAction);
                }
            }

            private void AuraAction(AIActor aiactor, float d)
            {
                BulletStatusEffectItem f = (BulletStatusEffectItem)PickupObjectDatabase.GetById(295);
                aiactor.ApplyEffect(f.FireModifierEffect, 1, null);
            }

            public void CancelFire(DebrisObject debris)
            {
                this.radialIndicatorActive = false;
                if (this.radialIndicator)
                {
                    this.radialIndicator.EndEffect();
                }
                this.radialIndicator = null;
            }

            private Projectile proj;
            private bool radialIndicatorActive;
            private HeatIndicatorController radialIndicator;
        }

        public class SynergyHooks
        {
            public static void PanaceaUseHook(Action<Panacea, PlayerController> orig, Panacea self, PlayerController user)
            {
                orig(self, user);
                List<int> OptionalItemIDs = new List<int>
                {
                    64,
                    174,
                    267,
                    168,
                    205,
                    427,
                    426,
                    424
                };
                bool hasMysteriousBrewSynergy = false;
                foreach (PlayerItem active in user.activeItems)
                {
                    if (OptionalItemIDs.Contains(active.PickupObjectId))
                    {
                        hasMysteriousBrewSynergy = true;
                    }
                }
                foreach (PassiveItem passive in user.passiveItems)
                {
                    if (OptionalItemIDs.Contains(passive.PickupObjectId))
                    {
                        hasMysteriousBrewSynergy = true;
                    }
                }
                if (hasMysteriousBrewSynergy)
                {
                    int value = UnityEngine.Random.Range(1, 9);
                    string header = "";
                    string text = "";
                    if (value == 1)
                    {
                        header = "?";
                        text = "Nothing happened.";
                    }
                    else if (value == 2)
                    {
                        header = "Invigorated";
                        text = "You feel healthier.";
                        StatModifier mod = new StatModifier
                        {
                            statToBoost = PlayerStats.StatType.Health,
                            amount = 1,
                            modifyType = StatModifier.ModifyMethod.ADDITIVE,
                        };
                        user.ownerlessStatModifiers.Add(mod);
                        user.stats.RecalculateStats(user, true, false);
                    }
                    else if (value == 3)
                    {
                        header = "Overloaded";
                        text = "The brew explodes.";
                        Exploder.DoDefaultExplosion(user.sprite.WorldCenter, new Vector2());
                    }
                    else if (value == 4)
                    {
                        header = "Pathetic";
                        text = "You feel weaker.";
                        StatModifier mod = new StatModifier
                        {
                            statToBoost = PlayerStats.StatType.Damage,
                            amount = -0.20f,
                            modifyType = StatModifier.ModifyMethod.ADDITIVE,
                        };
                        StatModifier mod2 = new StatModifier
                        {
                            statToBoost = PlayerStats.StatType.ThrownGunDamage,
                            amount = 0,
                            modifyType = StatModifier.ModifyMethod.MULTIPLICATIVE,
                        };
                        user.ownerlessStatModifiers.Add(mod);
                        user.ownerlessStatModifiers.Add(mod2);
                        user.stats.RecalculateStats(user, true, false);
                    }
                    else if (value == 5)
                    {
                        header = "Fast Reaction";
                        text = "Bullets are slow to you.";
                        StatModifier mod2 = new StatModifier
                        {
                            statToBoost = PlayerStats.StatType.EnemyProjectileSpeedMultiplier,
                            amount = 0.90f,
                            modifyType = StatModifier.ModifyMethod.MULTIPLICATIVE,
                        };
                        user.ownerlessStatModifiers.Add(mod2);
                        user.stats.RecalculateStats(user, true, false);
                    }
                    else if (value == 6)
                    {
                        header = "Slow Hands";
                        text = "Slower charge and reload.";
                        StatModifier mod2 = new StatModifier
                        {
                            statToBoost = PlayerStats.StatType.ReloadSpeed,
                            amount = 0.10f,
                            modifyType = StatModifier.ModifyMethod.ADDITIVE,
                        };
                        StatModifier mod1 = new StatModifier
                        {
                            statToBoost = PlayerStats.StatType.ChargeAmountMultiplier,
                            amount = -0.10f,
                            modifyType = StatModifier.ModifyMethod.ADDITIVE,
                        };
                        user.ownerlessStatModifiers.Add(mod2);
                        user.ownerlessStatModifiers.Add(mod1);
                        user.stats.RecalculateStats(user, true, false);
                    }
                    else if (value == 7)
                    {
                        header = "Flammable";
                        text = "You feel vulnerable to fire.";
                        DamageTypeModifier mod = new DamageTypeModifier
                        {
                            damageType = CoreDamageTypes.Fire,
                            damageMultiplier = 2
                        };
                        user.healthHaver.damageTypeModifiers.Add(mod);
                    }
                    else if (value == 8)
                    {
                        header = "Obsidian Skin";
                        text = "You feel immune to fire.";
                        DamageTypeModifier mod = new DamageTypeModifier
                        {
                            damageType = CoreDamageTypes.Fire,
                            damageMultiplier = 0
                        };
                        user.healthHaver.damageTypeModifiers.Add(mod);
                    }
                    else if (value == 9)
                    {
                        header = "Bulletproof";
                        text = "You feel almost invulnerable!";
                        void ModifyDamageEvent(HealthHaver healthHaver, HealthHaver.ModifyDamageEventArgs args)
                        {
                            if (args == EventArgs.Empty)
                            {
                                return;
                            }
                            if (UnityEngine.Random.value < 0.2f)
                            {
                                args.ModifiedDamage = 0f;
                            }
                        }
                        user.healthHaver.ModifyDamage += ModifyDamageEvent;
                    }

                    NoPseudosynergiesModule.Notify(header, text, self.sprite);
                }
            }

            public static void TableFlipAssasinHook(Action<Tabletechstealth, FlippableCover> orig, Tabletechstealth self, FlippableCover table)
            {
                orig(self, table);
                List<int> OptionalItemIDs = new List<int>
                {
                    524,
                    341,
                    436
                };
                bool hasAssasinSynergy = false;
                foreach (PlayerItem active in self.Owner.activeItems)
                {
                    if (OptionalItemIDs.Contains(active.PickupObjectId))
                    {
                        hasAssasinSynergy = true;
                    }
                }
                foreach (PassiveItem passive in self.Owner.passiveItems)
                {
                    if (OptionalItemIDs.Contains(passive.PickupObjectId))
                    {
                        hasAssasinSynergy = true;
                    }
                }
                if (hasAssasinSynergy)
                {
                    if (self.Owner.IsInCombat)
                    {
                        RoomHandler room = self.Owner.CurrentRoom;
                        float distance = float.MaxValue;
                        AIActor nearestenemy = null;
                        foreach (AIActor enemy in room.GetActiveEnemies(RoomHandler.ActiveEnemyType.All))
                        {
                            if (Vector2.Distance(table.sprite.WorldCenter, enemy.sprite.WorldCenter) < distance)
                            {
                                distance = Vector2.Distance(table.sprite.WorldCenter, enemy.sprite.WorldCenter);
                                nearestenemy = enemy;
                            }
                        }
                        if (nearestenemy != null)
                        {
                            //Pixelator.Instance.FadeToColor(0.1f, Color.white, true, 0.1f);
                            nearestenemy.healthHaver.ApplyDamage(UnityEngine.Random.Range(15, 30), table.sprite.WorldCenter - nearestenemy.sprite.WorldCenter, "Hidden Tech Assassin", CoreDamageTypes.None, DamageCategory.Unstoppable, true, null, false);
                        }
                    }
                }
            }

            public static void DisciplineHook(Action<DisciplineRing, PlayerController> orig, DisciplineRing self, PlayerController player)
            {
                if (player.HasPickupID(ETGMod.Databases.Items["Unstable Dodgicite Ring"].PickupObjectId))
                {
                    self.NoDodge = false;
                }
                else
                {
                    orig(self, player);
                }
            }

            public static void RecycloaderHook(Action<Recycloader, PlayerController> orig, Recycloader self, PlayerController user)
            {
                if (user.HasPickupID(116))
                {
                    if (user.CurrentGun.ammo == 0)
                    {
                        if (UnityEngine.Random.value >= 0.25f)
                        {
                            GameManager.Instance.StartCoroutine(SpewGun(user));
                        }
                    }
                }
                orig(self, user);
            }

            public static IEnumerator SpewGun(PlayerController user)
            {
                yield return new WaitForSeconds(0.5f);
                PlayerController lastOwner = user;
                float num = UnityEngine.Random.Range(0f, 1f);
                bool flag = (double)num < 0.7;
                bool flag2 = flag;
                if (flag2)
                {
                    PickupObject.ItemQuality itemQuality = PickupObject.ItemQuality.D;
                    PickupObject itemOfTypeAndQuality = LootEngine.GetItemOfTypeAndQuality<PickupObject>(itemQuality, GameManager.Instance.RewardManager.GunsLootTable, false);
                    bool flag3 = itemOfTypeAndQuality;
                    if (flag3)
                    {
                        LootEngine.SpawnItem(itemOfTypeAndQuality.gameObject, lastOwner.CenterPosition, Vector2.up, 1f, true, true, false);
                    }
                }
                else
                {
                    bool flag4 = (double)num < 0.85;
                    bool flag5 = flag4;
                    if (flag5)
                    {
                        PickupObject.ItemQuality itemQuality2 = PickupObject.ItemQuality.C;
                        PickupObject itemOfTypeAndQuality2 = LootEngine.GetItemOfTypeAndQuality<PickupObject>(itemQuality2, GameManager.Instance.RewardManager.GunsLootTable, false);
                        bool flag6 = itemOfTypeAndQuality2;
                        if (flag6)
                        {
                            LootEngine.SpawnItem(itemOfTypeAndQuality2.gameObject, lastOwner.CenterPosition, Vector2.up, 1f, true, true, false);
                        }
                    }
                    else
                    {
                        bool flag7 = (double)num < 0.95;
                        bool flag8 = flag7;
                        if (flag8)
                        {
                            PickupObject.ItemQuality itemQuality3 = PickupObject.ItemQuality.B;
                            PickupObject itemOfTypeAndQuality3 = LootEngine.GetItemOfTypeAndQuality<PickupObject>(itemQuality3, GameManager.Instance.RewardManager.GunsLootTable, false);
                            bool flag9 = itemOfTypeAndQuality3;
                            if (flag9)
                            {
                                LootEngine.SpawnItem(itemOfTypeAndQuality3.gameObject, lastOwner.CenterPosition, Vector2.up, 1f, true, true, false);
                            }
                        }
                        else
                        {
                            bool flag10 = (double)num < 0.98;
                            bool flag11 = flag10;
                            if (flag11)
                            {
                                PickupObject.ItemQuality itemQuality4 = PickupObject.ItemQuality.A;
                                PickupObject itemOfTypeAndQuality4 = LootEngine.GetItemOfTypeAndQuality<PickupObject>(itemQuality4, GameManager.Instance.RewardManager.GunsLootTable, false);
                                bool flag12 = itemOfTypeAndQuality4;
                                if (flag12)
                                {
                                    LootEngine.SpawnItem(itemOfTypeAndQuality4.gameObject, lastOwner.CenterPosition, Vector2.up, 1f, true, true, false);
                                }
                            }
                            else
                            {
                                PickupObject.ItemQuality itemQuality5 = PickupObject.ItemQuality.S;
                                PickupObject itemOfTypeAndQuality5 = LootEngine.GetItemOfTypeAndQuality<PickupObject>(itemQuality5, GameManager.Instance.RewardManager.GunsLootTable, false);
                                bool flag13 = itemOfTypeAndQuality5;
                                if (flag13)
                                {
                                    LootEngine.SpawnItem(itemOfTypeAndQuality5.gameObject, lastOwner.CenterPosition, Vector2.up, 1f, true, true, false);
                                }
                            }
                        }
                    }
                }
                yield break;
            }

            public static void MetronomeHook(Action<MetronomeItem> orig, MetronomeItem self)
            {
                orig(self);
                if (self.Owner.HasPickupID(ETGMod.Databases.Items["Boombox"].PickupObjectId))
                {
                    if (self.Owner.IsInCombat)
                    {
                        RoomHandler absoluteRoom = self.Owner.CurrentRoom;
                        List<AIActor> activeEnemies = absoluteRoom.GetActiveEnemies(RoomHandler.ActiveEnemyType.All);
                        bool flag = activeEnemies != null;
                        if (flag)
                        {
                            for (int i = 0; i < activeEnemies.Count; i++)
                            {
                                bool flag2 = activeEnemies[i] && activeEnemies[i].behaviorSpeculator;
                                if (flag2)
                                {
                                    activeEnemies[i].behaviorSpeculator.Stun(0.4f + ((self.GetCurrentMultiplier() - 1) / 2), true);
                                }
                            }
                        }
                    }
                }
            }

            public static void OuroborosUpdateHook(Action<Ouroboros, PlayerController> orig, Ouroboros self, PlayerController user)
            {
                orig(self, user);
                if (user.HasPickupID(ETGMod.Databases.Items["Recycloader"].PickupObjectId))
                {
                    EncounterTrackable.SuppressNextNotification = true;
                    LootEngine.GivePrefabToPlayer(ETGMod.Databases.Items["Ouroboros"].gameObject, user);
                    foreach (PlayerItem active in user.activeItems)
                    {
                        if (active is Ouroboros)
                        {
                            active.timeCooldown = -1f;
                            active.damageCooldown = 700;
                            active.ForceApplyCooldown(user);
                        }
                    }
                }
            }

            public static void MetronomeHook2(Action<MetronomeItem, Gun> orig, MetronomeItem self, Gun gun)
            {
                if (!self.Owner.HasPickupID(ETGMod.Databases.Items["Charlatan's Crown"].PickupObjectId))
                {
                    orig(self, gun);
                }
            }

            public static float MetronomeHook3(Func<MetronomeItem, float> orig, MetronomeItem self)
            {
                float value = orig(self);
                if (self.Owner.HasPickupID(ETGMod.Databases.Items["Charlatan's Crown"].PickupObjectId))
                {
                    value -= 1f;
                    value /= 5f;
                    value += 1f;
                }
                return value;
            }

            public static void MindControlHook(Action<MindControlDevice, PlayerController> orig, MindControlDevice self, PlayerController user)
            {
                if (user.HasPickupID(511))
                {
                    self.damageCooldown = 550;
                }
                else
                {
                    self.damageCooldown = 700;
                }
                orig(self, user);
            }

            public static void CigarettesHook(Action<SpawnObjectPlayerItem, PlayerController> orig, SpawnObjectPlayerItem self, PlayerController user)
            {
                orig(self, user);
                if (self.IsCigarettes)
                {
                    if (user.HasPickupID(ETGMod.Databases.Items["Invoker"].PickupObjectId))
                    {
                        StatModifier statModifier = new StatModifier();
                        statModifier.statToBoost = PlayerStats.StatType.Coolness;
                        statModifier.modifyType = StatModifier.ModifyMethod.ADDITIVE;
                        statModifier.amount = 1f;
                        user.ownerlessStatModifiers.Add(statModifier);
                        user.stats.RecalculateStats(user, false, false);
                    }
                }
            }

            public static void InvokerHook(Action<Invoker, PlayerController> orig, Invoker self, PlayerController user)
            {
                if (user.HasPickupID(203))
                {
                    self.damageCooldown = 200;
                }
                else
                {
                    self.damageCooldown = 400;
                }
                orig(self, user);
                if (user.HasPickupID(203))
                {
                    Projectile proj = (PickupObjectDatabase.GetById(38) as Gun).DefaultModule.projectiles[0];
                    BraveInput instanceForPlayer = BraveInput.GetInstanceForPlayer(user.PlayerIDX);
                    bool flag2 = instanceForPlayer == null;
                    float z = 0;
                    if (!flag2)
                    {
                        bool flag3 = instanceForPlayer.IsKeyboardAndMouse(false);
                        Vector2 a;
                        if (flag3)
                        {
                            a = user.unadjustedAimPoint.XY() - self.sprite.WorldCenter;
                        }
                        else
                        {
                            bool flag4 = instanceForPlayer.ActiveActions == null;
                            if (flag4)
                            {
                                return;
                            }
                            a = instanceForPlayer.ActiveActions.Aim.Vector;
                        }
                        a.Normalize();
                        z = BraveMathCollege.Atan2Degrees(a);
                    }
                    GameObject obj = SpawnManager.SpawnProjectile(proj.gameObject, user.sprite.WorldCenter, Quaternion.Euler(0, 0, z));
                    Projectile proj2 = obj.GetComponent<Projectile>();
                    if (proj2 != null)
                    {
                        proj2.Owner = user;
                        proj2.Shooter = user.specRigidbody;
                        proj2.baseData.damage *= ((user.stats.GetStatValue(PlayerStats.StatType.Coolness) / 2) + 1);
                    }
                }
            }

            public static void GravityGlobeHook(Action<GravityGlove, Projectile> orig, GravityGlove self, Projectile thrown)
            {
                orig(self, thrown);
                if (self.Owner.HasPickupID(440))
                {
                    thrown.gameObject.AddComponent<FuriousThrowingSynergyController>();
                }
            }

            public static void VerdantHook(Action<Leafblower, Projectile> orig, Leafblower self, Projectile proj)
            {
                orig(self, proj);
                if(self.GetComponent<Gun>().CurrentOwner is PlayerController && (self.GetComponent<Gun>().CurrentOwner as PlayerController).HasPickupID(339))
                {
                    proj.baseData.damage *= 1.3f;
                    proj.baseData.speed *= 2f;
                }
            }

            public static void ConstructorHook(Action<Craftsman, Projectile, SpeculativeRigidbody> orig, Craftsman self, Projectile proj, SpeculativeRigidbody enemy)
            {
                orig(self, proj, enemy);
                bool hasSynergy = false;
                List<int> OptionalItemIDs = new List<int>
                {
                    66,
                    201,
                    644
                };
                foreach(PlayerItem active in (self.GetComponent<Gun>().CurrentOwner as PlayerController).activeItems)
                {
                    if (OptionalItemIDs.Contains(active.PickupObjectId))
                    {
                        hasSynergy = true;
                    }
                }
                if (hasSynergy)
                {
                    orig(self, proj, enemy);
                    if(UnityEngine.Random.value < 0.05)
                    {
                        orig(self, proj, enemy);
                    }
                }
            }
        }
    }
}
