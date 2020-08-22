using System;
using System.Collections.Generic;
using Gungeon;
using ItemAPI;
using UnityEngine;
using Blunderbeast;

namespace NoPseudosynergies
{
    public class SynergyAlchemiser : GunBehaviour
    {
        public static void Add()
        {
            Gun gun = ETGMod.Databases.Items.NewGun("alchemical_gun_synergy", "alche");
            Game.Items.Rename("outdated_gun_mods:alchemical_gun_synergy", "rtr:alchemical_gun+full_charge");
            gun.gameObject.AddComponent<SynergyAlchemiser>();
            GunExt.SetShortDescription(gun, "Toxic Transmutation");
            GunExt.SetLongDescription(gun, "Transmutes poisoned enemies. Reload to create dangerous poisonous liquid.\n\nThe Alchemical Gun was created by an ancient denizen of the Oubliette. Some say the toxic environment was used by its owner to test the gun's capabilities. However, many suggest he had merely lost his mind being trapped in the sewers for so long.");
            GunExt.SetupSprite(gun, null, "alche_idle_001", 8);
            GunExt.SetAnimationFPS(gun, gun.shootAnimation, 32);
            GunExt.SetAnimationFPS(gun, gun.reloadAnimation, 16);
            Gun gun2 = PickupObjectDatabase.GetById(577) as Gun;
            Gun gun3 = PickupObjectDatabase.GetById(577) as Gun;
            GunExt.AddProjectileModuleFrom(gun, gun3, true, false);
            gun.SetBaseMaxAmmo(550);
            gun.DefaultModule.customAmmoType = gun2.DefaultModule.customAmmoType;
            gun.DefaultModule.ammoType = gun2.DefaultModule.ammoType;
            gun.DefaultModule.ammoCost = 1;
            gun.DefaultModule.shootStyle = ProjectileModule.ShootStyle.SemiAutomatic;
            gun.damageModifier = 1;
            gun.reloadTime = 1.9f;
            gun.barrelOffset.transform.localPosition += new Vector3(-0.1f, -0f, 0f);
            gun.DefaultModule.cooldownTime = 0.25f;
            gun.DefaultModule.numberOfShotsInClip = 15;
            gun.DefaultModule.angleVariance = 3f;
            gun.quality = PickupObject.ItemQuality.EXCLUDED;
            gun.encounterTrackable.EncounterGuid = "alchemiser_synergy_cool";
            gun.gunClass = GunClass.RIFLE;
            gun.CanBeDropped = true;
            Gun gun4 = PickupObjectDatabase.GetById(61) as Gun;
            gun.muzzleFlashEffects = gun4.muzzleFlashEffects;
            Projectile projectile = UnityEngine.Object.Instantiate<Projectile>(gun2.DefaultModule.projectiles[0]);
            projectile.gameObject.SetActive(false);
            NoPseudosynergies.ItemAPI.FakePrefab.MarkAsFakePrefab(projectile.gameObject);
            UnityEngine.Object.DontDestroyOnLoad(projectile);
            gun.DefaultModule.projectiles[0] = projectile;
            projectile.transform.parent = gun.barrelOffset;
            projectile.AdditionalScaleMultiplier *= 1.6f;
            projectile.baseData.damage *= 2f;
            projectile.sprite.color = Color.green;
            AssetBundle assetBundle = ResourceManager.LoadAssetBundle("shared_auto_001");
            SynergyAlchemiser.goopDefs = new List<GoopDefinition>();
            foreach (string text in SynergyAlchemiser.goops)
            {
                GoopDefinition goopDefinition;
                try
                {
                    GameObject gameObject = assetBundle.LoadAsset(text) as GameObject;
                    goopDefinition = gameObject.GetComponent<GoopDefinition>();
                }
                catch
                {
                    goopDefinition = (assetBundle.LoadAsset(text) as GoopDefinition);
                }
                goopDefinition.name = text.Replace("assets/data/goops/", "").Replace(".asset", "");
                SynergyAlchemiser.goopDefs.Add(goopDefinition);
            }
            List<GoopDefinition> list = SynergyAlchemiser.goopDefs;
            ETGMod.Databases.Items.Add(gun, null, "ANY");
        }

        protected void Update()
        {
            PlayerController playerController = this.gun.CurrentOwner as PlayerController;
            bool flag = playerController && playerController != null;
            if (flag)
            {
                bool flag2 = !this.gun.PreventNormalFireAudio;
                if (flag2)
                {
                    this.gun.PreventNormalFireAudio = true;
                }
                bool flag3 = !this.gun.IsReloading && !this.HasReloaded;
                if (flag3)
                {
                    this.HasReloaded = true;
                }
                bool flag4 = playerController.HasPickupID(205) || playerController.HasPickupID(815);
                if (flag4)
                {
                    DeadlyDeadlyGoopManager.GetGoopManagerForGoopType(SynergyAlchemiser.goopDefs[0]).TimedAddGoopCircle(playerController.sprite.WorldBottomCenter, 1f, 0.25f, false);
                    bool flag5 = !this.HasImmunity;
                    if (flag5)
                    {
                        this.HasImmunity = true;
                        this.m_poisonImmunity = new DamageTypeModifier();
                        this.m_poisonImmunity.damageMultiplier = 0f;
                        this.m_poisonImmunity.damageType = CoreDamageTypes.Poison;
                        playerController.healthHaver.damageTypeModifiers.Add(this.m_poisonImmunity);
                    }
                }
            }
        }

        public override void PostProcessProjectile(Projectile projectile)
        {
            PlayerController x = this.gun.CurrentOwner as PlayerController;
            bool flag = x == null;
            bool flag2 = flag;
            if (flag2)
            {
                this.gun.ammo = this.gun.GetBaseMaxAmmo();
            }
            this.gun.DefaultModule.ammoCost = 1;
            projectile.OnHitEnemy = (Action<Projectile, SpeculativeRigidbody, bool>)Delegate.Combine(projectile.OnHitEnemy, new Action<Projectile, SpeculativeRigidbody, bool>(this.HandleHit));
        }

        private void HandleHit(Projectile arg1, SpeculativeRigidbody arg2, bool arg3)
        {
            bool flag = arg2.aiActor != null && !arg2.healthHaver.IsBoss && !arg2.healthHaver.IsDead && arg2.aiActor.behaviorSpeculator && !arg2.aiActor.IsHarmlessEnemy && arg2.aiActor != null;
            if (flag)
            {
                GameActorEffect effect = arg2.aiActor.GetEffect(DeadlyDeadlyGoopManager.GetGoopManagerForGoopType(SynergyAlchemiser.goopDefs[0]).goopDefinition.HealthModifierEffect.effectIdentifier);
                bool flag2 = effect != null;
                if (flag2)
                {
                    AIActor orLoadByGuid = EnemyDatabase.GetOrLoadByGuid("8b43a5c59b854eb780f9ab669ec26b7a");
                    arg2.aiActor.EraseFromExistenceWithRewards(true);
                    AIActor aiactor = AIActor.Spawn(orLoadByGuid, arg2.aiActor.CenterPosition, arg2.transform.position.GetAbsoluteRoom(), true, AIActor.AwakenAnimationType.Awaken, true);
                    LootEngine.DoDefaultItemPoof(aiactor.CenterPosition, false, false);
                    aiactor.DiesOnCollison = true;
                    aiactor.ImmuneToAllEffects = true;
                }
            }
        }

        public override void OnReloadPressed(PlayerController player, Gun gun, bool bSOMETHING)
        {
            bool flag = gun.IsReloading && this.HasReloaded;
            if (flag)
            {
                float duration = 0.75f;
                bool flag2 = gun.ClipShotsRemaining == 0;
                if (flag2)
                {
                    DeadlyDeadlyGoopManager.GetGoopManagerForGoopType(SynergyAlchemiser.goopDefs[0]).TimedAddGoopCircle(gun.sprite.WorldBottomCenter, 3.75f, duration, false);
                }
                else
                {
                    bool flag3 = gun.ClipShotsRemaining == 1;
                    if (flag3)
                    {
                        DeadlyDeadlyGoopManager.GetGoopManagerForGoopType(SynergyAlchemiser.goopDefs[0]).TimedAddGoopCircle(gun.sprite.WorldBottomCenter, 3.5f, duration, false);
                    }
                    else
                    {
                        bool flag4 = gun.ClipShotsRemaining == 2;
                        if (flag4)
                        {
                            DeadlyDeadlyGoopManager.GetGoopManagerForGoopType(SynergyAlchemiser.goopDefs[0]).TimedAddGoopCircle(gun.sprite.WorldBottomCenter, 3.25f, duration, false);
                        }
                        else
                        {
                            bool flag5 = gun.ClipShotsRemaining == 3;
                            if (flag5)
                            {
                                DeadlyDeadlyGoopManager.GetGoopManagerForGoopType(SynergyAlchemiser.goopDefs[0]).TimedAddGoopCircle(gun.sprite.WorldBottomCenter, 3f, duration, false);
                            }
                            else
                            {
                                bool flag6 = gun.ClipShotsRemaining == 4;
                                if (flag6)
                                {
                                    DeadlyDeadlyGoopManager.GetGoopManagerForGoopType(SynergyAlchemiser.goopDefs[0]).TimedAddGoopCircle(gun.sprite.WorldBottomCenter, 2.5f, duration, false);
                                }
                                else
                                {
                                    bool flag7 = gun.ClipShotsRemaining == 5;
                                    if (flag7)
                                    {
                                        DeadlyDeadlyGoopManager.GetGoopManagerForGoopType(SynergyAlchemiser.goopDefs[0]).TimedAddGoopCircle(gun.sprite.WorldBottomCenter, 2.25f, duration, false);
                                    }
                                    else
                                    {
                                        bool flag8 = gun.ClipShotsRemaining >= 6;
                                        if (flag8)
                                        {
                                            DeadlyDeadlyGoopManager.GetGoopManagerForGoopType(SynergyAlchemiser.goopDefs[0]).TimedAddGoopCircle(gun.sprite.WorldBottomCenter, 2f, duration, false);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                this.HasReloaded = false;
                AkSoundEngine.PostEvent("Stop_WPN_All", base.gameObject);
                base.OnReloadPressed(player, gun, bSOMETHING);
                AkSoundEngine.PostEvent("Play_OBJ_coolant_leak_01", base.gameObject);
            }
        }

        public override void OnPostFired(PlayerController player, Gun gun)
        {
            AkSoundEngine.PostEvent("Play_WPN_bountyhunterarm_shot_02", base.gameObject);
        }

        public static List<GoopDefinition> goopDefs;

        private bool HasReloaded;

        private bool HasImmunity;

        private DamageTypeModifier m_poisonImmunity;

        public GameActorHealthEffect HealthModifierEffect;

        private static string[] goops = new string[]
        {
            "assets/data/goops/poison goop.asset"
        };
    }
}
