using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MakingAnItem;
using Items;
using Blunderbeast;
using MonoMod.RuntimeDetour;
using System.Collections;
using System.Reflection;
using UnityEngine;
using CustomItems;

namespace NoPseudosynergies
{
    public class NoPseudosynergiesModule : ETGModule
    {
        public override void Init()
        {
        }

        public override void Start()
        {
            GameManager.Instance.StartCoroutine(this.d());
        }

        public IEnumerator d()
        {
            yield return new WaitForSeconds(5f);
            NoPseudosynergies.ItemAPI.FakePrefabHooks.Init();
            NoPseudosynergies.ItemAPI.ItemBuilder.Init();
            foreach (ETGModule mod in ETGMod.GameMods)
            {
                if (mod is CelsItems)
                {
                    this.hasCel = true;
                }
                else if (mod is TestItem)
                {
                    this.hasNevernamed = true;
                }
                else if (mod is Blunderbeast.CustomItems)
                {
                    this.hasRetrash = true;
                }
                else if (mod is CustomItemsMod)
                {
                    this.hasKyle = true;
                }
            }
            bool dependencyComplete = this.hasCel || this.hasNevernamed;
            if (!dependencyComplete)
            {
                ETGModConsole.Log("[NoPseudosynergies] No dependency found! Install at least one of it's dependencies for it to work!");
            }
            else
            {
                Hook synergyStringHook = new Hook(
                    typeof(StringTableManager).GetMethod("GetSynergyString", BindingFlags.Public | BindingFlags.Static),
                    typeof(NoPseudosynergiesModule).GetMethod("SynergyStringHook")
                );
                ETGModConsole.Log("[NoPseudosynergies] Setup complete. Making synergies for items from: ");
                GameManager.Instance.SynergyManager.synergies = GameManager.Instance.SynergyManager.synergies.Concat(new AdvancedSynergyEntry[] { new CustomSynergiesVanilla.HeroOfChicken() }).ToArray();
                ETGModConsole.Log("     * Vanilla");
                if (this.hasCel)
                {
                    //ETGModConsole.Log("     * Cel's Items");
                }
                if (this.hasNevernamed)
                {
                    //ETGModConsole.Log("     * Nevernamed's Items");
                }
                if (this.hasRetrash)
                {
                    SynergyAlchemiser.Add();
                    GameManager.Instance.SynergyManager.synergies = GameManager.Instance.SynergyManager.synergies.Concat(new AdvancedSynergyEntry[] { new CustomSynergiesRetrash.MysteriousBrewSynergy() }).ToArray();
                    Hook panaceaUseHook = new Hook(
                        typeof(Panacea).GetMethod("DoEffect", BindingFlags.NonPublic | BindingFlags.Instance),
                        typeof(CustomSynergiesRetrash.SynergyHooks).GetMethod("PanaceaUseHook")
                    );
                    GameManager.Instance.SynergyManager.synergies = GameManager.Instance.SynergyManager.synergies.Concat(new AdvancedSynergyEntry[] { new CustomSynergiesRetrash.HiddenTechMurderSynergy() }).ToArray();
                    Hook assasinHook = new Hook(
                        typeof(Tabletechstealth).GetMethod("StealthEffect", BindingFlags.NonPublic | BindingFlags.Instance),
                        typeof(CustomSynergiesRetrash.SynergyHooks).GetMethod("TableFlipAssasinHook")
                    );
                    GameManager.Instance.SynergyManager.synergies = GameManager.Instance.SynergyManager.synergies.Concat(new AdvancedSynergyEntry[] { new CustomSynergiesRetrash.NotSoHarsh() }).ToArray();
                    Hook disciplineHook = new Hook(
                        typeof(DisciplineRing).GetMethod("DodgeFail", BindingFlags.NonPublic | BindingFlags.Instance),
                        typeof(CustomSynergiesRetrash.SynergyHooks).GetMethod("DisciplineHook")
                    );
                    GameManager.Instance.SynergyManager.synergies = GameManager.Instance.SynergyManager.synergies.Concat(new AdvancedSynergyEntry[] { new CustomSynergiesRetrash.RecycloadedGoodiesSynergy() }).ToArray();
                    Hook recycloaderHook = new Hook(
                        typeof(Recycloader).GetMethod("DoEffect", BindingFlags.NonPublic | BindingFlags.Instance),
                        typeof(CustomSynergiesRetrash.SynergyHooks).GetMethod("RecycloaderHook")
                    );
                    GameManager.Instance.SynergyManager.synergies = GameManager.Instance.SynergyManager.synergies.Concat(new AdvancedSynergyEntry[] { new CustomSynergiesRetrash.QualityMusicSynergy() }).ToArray();
                    Hook metronomeHook = new Hook(
                        typeof(MetronomeItem).GetMethod("DoMetronomeUp", BindingFlags.NonPublic | BindingFlags.Instance),
                        typeof(CustomSynergiesRetrash.SynergyHooks).GetMethod("MetronomeHook")
                    );
                    GameManager.Instance.SynergyManager.synergies = GameManager.Instance.SynergyManager.synergies.Concat(new AdvancedSynergyEntry[] { new CustomSynergiesRetrash.DoubleInfinitySynergy() }).ToArray();
                    Hook ouroborosHook = new Hook(
                        typeof(Ouroboros).GetMethod("DoEffect", BindingFlags.NonPublic | BindingFlags.Instance),
                        typeof(CustomSynergiesRetrash.SynergyHooks).GetMethod("OuroborosUpdateHook")
                    );
                    GameManager.Instance.SynergyManager.synergies = GameManager.Instance.SynergyManager.synergies.Concat(new AdvancedSynergyEntry[] { new CustomSynergiesRetrash.FalseMusicantSynergy() }).ToArray();
                    Hook metronomeHook2 = new Hook(
                        typeof(MetronomeItem).GetMethod("DoMetronomeBroken", BindingFlags.NonPublic | BindingFlags.Instance),
                        typeof(CustomSynergiesRetrash.SynergyHooks).GetMethod("MetronomeHook2")
                    );
                    Hook metronomeHook3 = new Hook(
                        typeof(MetronomeItem).GetMethod("GetCurrentMultiplier", BindingFlags.Public | BindingFlags.Instance),
                        typeof(CustomSynergiesRetrash.SynergyHooks).GetMethod("MetronomeHook3")
                    );
                    GameManager.Instance.SynergyManager.synergies = GameManager.Instance.SynergyManager.synergies.Concat(new AdvancedSynergyEntry[] { new CustomSynergiesRetrash.SecondPartyControl() }).ToArray();
                    Hook mindControlhook = new Hook(
                        typeof(MindControlDevice).GetMethod("DoEffect", BindingFlags.NonPublic | BindingFlags.Instance),
                        typeof(CustomSynergiesRetrash.SynergyHooks).GetMethod("MindControlHook")
                    );
                    GameManager.Instance.SynergyManager.synergies = GameManager.Instance.SynergyManager.synergies.Concat(new AdvancedSynergyEntry[] { new CustomSynergiesRetrash.SelfHarmSynergy() }).ToArray();
                    Hook cigarettesHook = new Hook(
                        typeof(SpawnObjectPlayerItem).GetMethod("DoEffect", BindingFlags.NonPublic | BindingFlags.Instance),
                        typeof(CustomSynergiesRetrash.SynergyHooks).GetMethod("CigarettesHook")
                    );
                    Hook invokerHook = new Hook(
                        typeof(Invoker).GetMethod("DoEffect", BindingFlags.NonPublic | BindingFlags.Instance),
                        typeof(CustomSynergiesRetrash.SynergyHooks).GetMethod("InvokerHook")
                    );
                    GameManager.Instance.SynergyManager.synergies = GameManager.Instance.SynergyManager.synergies.Concat(new AdvancedSynergyEntry[] { new CustomSynergiesRetrash.ElementalShowerSynergy() }).ToArray();
                    ETGMod.Databases.Items["Roshambo"].gameObject.AddComponent<CustomSynergiesRetrash.ElementalShowerSynergyController>();
                    GameManager.Instance.SynergyManager.synergies = GameManager.Instance.SynergyManager.synergies.Concat(new AdvancedSynergyEntry[] { new CustomSynergiesRetrash.FuriousThrowingSynergy() }).ToArray();
                    Hook gravityGloveHook = new Hook(
                        typeof(GravityGlove).GetMethod("PostProcessThrownGun", BindingFlags.NonPublic | BindingFlags.Instance),
                        typeof(CustomSynergiesRetrash.SynergyHooks).GetMethod("GravityGlobeHook")
                    );
                    GameManager.Instance.SynergyManager.synergies = GameManager.Instance.SynergyManager.synergies.Concat(new AdvancedSynergyEntry[] { new CustomSynergiesRetrash.LeafDestructionSynergy() }).ToArray();
                    Hook verdantHook = new Hook(
                        typeof(Leafblower).GetMethod("PostProcessProjectile", BindingFlags.Public | BindingFlags.Instance),
                        typeof(CustomSynergiesRetrash.SynergyHooks).GetMethod("VerdantHook")
                    );
                    GameManager.Instance.SynergyManager.synergies = GameManager.Instance.SynergyManager.synergies.Concat(new AdvancedSynergyEntry[] { new CustomSynergiesRetrash.BestConstructorSynergy() }).ToArray();
                    Hook constructorHook = new Hook(
                        typeof(Craftsman).GetMethod("OnKill", BindingFlags.NonPublic | BindingFlags.Instance),
                        typeof(CustomSynergiesRetrash.SynergyHooks).GetMethod("ConstructorHook")
                    );
                    GameManager.Instance.SynergyManager.synergies = GameManager.Instance.SynergyManager.synergies.Concat(new AdvancedSynergyEntry[] { new CustomSynergiesRetrash.AlchemicalDischargeSynergy() }).ToArray();
                    ETGMod.Databases.Items["alchemiser"].gameObject.AddComponent<CustomSynergiesRetrash.FullChargeSynergyController>();
                    ETGModConsole.Log("     * Retrash's Custom Item Collection");
                }
            }
            yield break;
        }

        public static string SynergyStringHook(Func<string, int, string> action, string key, int index = -1)
        {
            string value = action(key, index);
            if (string.IsNullOrEmpty(value))
            {
                value = key;
            }
            return value;
        }

        public static void Notify(string header, string text, tk2dBaseSprite sprite = null)
        {
            tk2dBaseSprite notificationObjectSprite;
            if (sprite == null)
            {
                notificationObjectSprite = GameUIRoot.Instance.notificationController.notificationObjectSprite;
            }
            else
            {
                notificationObjectSprite = sprite;
            }
            GameUIRoot.Instance.notificationController.DoCustomNotification(header, text, notificationObjectSprite.Collection, notificationObjectSprite.spriteId, UINotificationController.NotificationColor.PURPLE, false, false);
        }

        public override void Exit()
        {
        }

        public bool hasCel = false;
        public bool hasNevernamed = false;
        public bool hasRetrash = false;
        public bool hasKyle = false;
    }
}
