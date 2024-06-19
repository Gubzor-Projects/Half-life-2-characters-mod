using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UmmAPI;
using System.Reflection;
namespace Mod
{
    public class Mod : MonoBehaviour
    {
        public static string ModTag = " [HLCM]";
        public static Sprite categorySprite = ModAPI.LoadSprite("Category.png");
        public static void Main()
        {
            ModAPI.RegisterCategory("Half Life 2 Characters Mod", "Half Life 2 Characters mod.", categorySprite);
            #region Content
            #region Gordon Freeman (civilian!!!!!!!)
            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Gordon Freeman (Citizen Suit)" + ModTag,
                    NameToOrderByOverride = "h",
                    DescriptionOverride = "He's a theoretical physicist, forced to defend himself and the human race in a conflict against hostile aliens and other enemies after a failed experiment causes a worldwide alien invasion.",
                    CategoryOverride = ModAPI.FindCategory("Half Life 2 Characters Mod"),
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Gordon Citizen.png", 5f),
                    AfterSpawn = (Instance) =>
                    {

                        var skin = ModAPI.LoadTexture("Sprites/Citizen.png");

                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin);

                        if (Instance.transform.localScale.x > 0f)
                        {
                            Instance.transform.localScale = new Vector3(1.12f, 1.12f, 1f);
                        }
                        else
                        {
                            Instance.transform.localScale = new Vector3(-1.12f, 1.12f, 1f);
                        }

                        #region Limb List
                        GameObject Head = Instance.transform.Find("Head").gameObject;
                        GameObject UpperBody = Instance.transform.Find("Body/UpperBody").gameObject;
                        GameObject MiddleBody = Instance.transform.Find("Body/MiddleBody").gameObject;
                        GameObject LowerBody = Instance.transform.Find("Body/LowerBody").gameObject;
                        GameObject LowerArm = Instance.transform.Find("BackArm/LowerArm").gameObject;
                        GameObject UpperArm = Instance.transform.Find("BackArm/UpperArm").gameObject;
                        GameObject LowerArmFront = Instance.transform.Find("FrontArm/LowerArmFront").gameObject;
                        GameObject UpperArmFront = Instance.transform.Find("FrontArm/UpperArmFront").gameObject;
                        #endregion

                        Head.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Gordon/Head Skin.png"), ModAPI.LoadSprite("Sprites/Gordon/Head Flesh.png"), ModAPI.LoadSprite("Sprites/Gordon/Head Skeleton.png"), ModAPI.LoadSprite("Sprites/Gordon/Head Damage.png"));
                    }
                }
            );
            #endregion
            #region Gordon Freeman
            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Gordon Freeman" + ModTag,
                    NameToOrderByOverride = "h",
                    DescriptionOverride = "He's a theoretical physicist, forced to defend himself and the human race in a conflict against hostile aliens and other enemies after a failed experiment causes a worldwide alien invasion.",
                    CategoryOverride = ModAPI.FindCategory("Half Life 2 Characters Mod"),
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Gordon.png", 5f),
                    AfterSpawn = (Instance) =>
                    {

                        var skin = ModAPI.LoadTexture("Sprites/Gordon/Skin.png");

                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin);
                        person.RandomisedSize = false;

                        var prop = ModAPI.FindPhysicalProperties("Metal");

                        foreach (var body in person.Limbs)
                        {
                            body.gameObject.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Metal");
                        }
                        foreach (var body in person.Limbs)
                        {
                            body.DiscomfortingHeatTemperature = 10000000000f;
                            body.ImpactDamageMultiplier = 0f;
                            body.ImpactPainMultiplier = 0f;
                            body.RegenerationSpeed = 7f;
                            body.Health = 350f;
                            body.HasBrain = false;
                            body.HasLungs = false;
                        }

                        if (Instance.transform.localScale.x > 0f)
                        {
                            Instance.transform.localScale = new Vector3(1.12f, 1.12f, 1f);
                        }
                        else
                        {
                            Instance.transform.localScale = new Vector3(-1.12f, 1.12f, 1f);
                        }

                        #region Limb List
                        GameObject Head = Instance.transform.Find("Head").gameObject;
                        GameObject UpperBody = Instance.transform.Find("Body/UpperBody").gameObject;
                        GameObject MiddleBody = Instance.transform.Find("Body/MiddleBody").gameObject;
                        GameObject LowerBody = Instance.transform.Find("Body/LowerBody").gameObject;
                        GameObject LowerArm = Instance.transform.Find("BackArm/LowerArm").gameObject;
                        GameObject UpperArm = Instance.transform.Find("BackArm/UpperArm").gameObject;
                        GameObject LowerArmFront = Instance.transform.Find("FrontArm/LowerArmFront").gameObject;
                        GameObject UpperArmFront = Instance.transform.Find("FrontArm/UpperArmFront").gameObject;
                        #endregion

                        Head.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Human");
                        Head.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Gordon/Head Skin.png"), ModAPI.LoadSprite("Sprites/Gordon/Head Flesh.png"), ModAPI.LoadSprite("Sprites/Gordon/Head Skeleton.png"), ModAPI.LoadSprite("Sprites/Gordon/Head Damage.png"));
                        LowerBody.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Gordon/Lowe Body Skin.png"), ModAPI.LoadSprite("Sprites/Gordon/Lower Body Flesh.png"), ModAPI.LoadSprite("Sprites/Gordon/Lower Body Skeleton.png"), ModAPI.LoadSprite("Sprites/Gordon/Lower Body Damage.png"));
                    }
                }
            );
            #endregion
            #region Barney Calhoun
            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Barney Calhoun" + ModTag,
                    NameToOrderByOverride = "h",
                    DescriptionOverride = "Barney Calhoun is the tritagonist of the Half-Life series. He worked as a security guard at the Black Mesa Research Facility before becoming a key Resistance leader.",
                    CategoryOverride = ModAPI.FindCategory("Half Life 2 Characters Mod"),
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Barney.png", 5f),
                    AfterSpawn = (Instance) =>
                    {

                        var skin = ModAPI.LoadTexture("Sprites/CCP/Skin.png");

                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin);
                        person.RandomisedSize = false;

                        var prop = ModAPI.FindPhysicalProperties("Metal");

                        foreach (var body in person.Limbs)
                        {
                            body.DiscomfortingHeatTemperature = 10000000000f;
                            body.ImpactDamageMultiplier = 0f;
                            body.ImpactPainMultiplier = 0f;
                            body.RegenerationSpeed = 4f;
                            body.Health = 250f;
                            body.HasBrain = false;
                            body.HasLungs = false;
                        }

                        if (Instance.transform.localScale.x > 0f)
                        {
                            Instance.transform.localScale = new Vector3(1.13f, 1.13f, 1f);
                        }
                        else
                        {
                            Instance.transform.localScale = new Vector3(-1.13f, 1.13f, 1f);
                        }

                        #region Limb List
                        GameObject Head = Instance.transform.Find("Head").gameObject;
                        GameObject UpperBody = Instance.transform.Find("Body/UpperBody").gameObject;
                        GameObject MiddleBody = Instance.transform.Find("Body/MiddleBody").gameObject;
                        GameObject LowerBody = Instance.transform.Find("Body/LowerBody").gameObject;
                        GameObject LowerArm = Instance.transform.Find("BackArm/LowerArm").gameObject;
                        GameObject UpperArm = Instance.transform.Find("BackArm/UpperArm").gameObject;
                        GameObject LowerArmFront = Instance.transform.Find("FrontArm/LowerArmFront").gameObject;
                        GameObject UpperArmFront = Instance.transform.Find("FrontArm/UpperArmFront").gameObject;
                        #endregion

                        UpperBody.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Metal");
                        UpperBody.GetOrAddComponent<AlwaysGoodBloodFlow>();
                        UpperBody.GetComponent<SkinMaterialHandler>().intensityMultiplier = 1f / 4f;
                        MiddleBody.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Metal");
                        MiddleBody.GetOrAddComponent<AlwaysGoodBloodFlow>();
                        MiddleBody.GetComponent<SkinMaterialHandler>().intensityMultiplier = 1f / 4f;
                        LowerBody.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Metal");
                        LowerBody.GetOrAddComponent<AlwaysGoodBloodFlow>();
                        LowerBody.GetComponent<SkinMaterialHandler>().intensityMultiplier = 1f / 4f;

                        Head.GetComponent<SpriteRenderer>().sortingLayerName = "Default";

                        LowerBody.GetComponent<SpriteRenderer>().sortingLayerName = "Foreground";
                        LowerBody.GetComponent<SpriteRenderer>().sortingOrder = 2;
                        LowerArmFront.GetComponent<SpriteRenderer>().sortingOrder = 3;

                        UpperBody.GetComponent<SpriteRenderer>().sortingOrder = 2;

                        Head.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/CCP/Barney Head.png"), ModAPI.LoadSprite("Sprites/CCP/Head Flesh.png"), ModAPI.LoadSprite("Sprites/CCP/Head Skeleton.png"), ModAPI.LoadSprite("Sprites/CCP/Head Damage.png"));
                        UpperBody.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/CCP/Upper Body Skin.png"), ModAPI.LoadSprite("Sprites/CCP/Upper Body Flesh.png"), ModAPI.LoadSprite("Sprites/CCP/Upper Body Skeleton.png"), ModAPI.LoadSprite("Sprites/CCP/Upper Body Damage.png"));
                        MiddleBody.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/CCP/Middle Body Skin.png"), ModAPI.LoadSprite("Sprites/CCP/Middle Body Flesh.png"), ModAPI.LoadSprite("Sprites/CCP/Middle Body Skeleton.png"), ModAPI.LoadSprite("Sprites/CCP/Middle Body Damage.png"));
                        LowerBody.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/CCP/Lower Body Skin.png"), ModAPI.LoadSprite("Sprites/CCP/Lower Body Flesh.png"), ModAPI.LoadSprite("Sprites/CCP/Lower Body Skeleton.png"), ModAPI.LoadSprite("Sprites/CCP/Lower Body Damage.png"));
                    }
                }
            );
            #endregion
            #region Isaac Kleiner
            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Isaac Kleiner" + ModTag,
                    NameToOrderByOverride = "h",
                    DescriptionOverride = "Dr. Isaac Kleiner is a scientist and one of the main characters of Half-Life 2 and its episodes. An archetypal 'absent-minded genius scientist' (although somewhat more benign), he is a prolific author of several works on teleportation and interdimensional travel, and one of the few survivors of the incident that took place in the Black Mesa Research Facility.",
                    CategoryOverride = ModAPI.FindCategory("Half Life 2 Characters Mod"),
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Kleiner.png", 5f),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Sprites/Kleiner/Skin.png");

                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin);

                        #region Limb List
                        GameObject Head = Instance.transform.Find("Head").gameObject;
                        GameObject UpperBody = Instance.transform.Find("Body/UpperBody").gameObject;
                        GameObject MiddleBody = Instance.transform.Find("Body/MiddleBody").gameObject;
                        GameObject LowerBody = Instance.transform.Find("Body/LowerBody").gameObject;
                        GameObject LowerArm = Instance.transform.Find("BackArm/LowerArm").gameObject;
                        GameObject UpperArm = Instance.transform.Find("BackArm/UpperArm").gameObject;
                        GameObject LowerArmFront = Instance.transform.Find("FrontArm/LowerArmFront").gameObject;
                        GameObject UpperArmFront = Instance.transform.Find("FrontArm/UpperArmFront").gameObject;
                        #endregion

                        if (Instance.transform.localScale.x > 0f)
                        {
                            Instance.transform.localScale = new Vector3(1.09f, 1.09f, 1f);
                        }
                        else
                        {
                            Instance.transform.localScale = new Vector3(-1.09f, 1.09f, 1f);
                        }

                        LowerBody.GetComponent<SpriteRenderer>().sortingLayerName = "Foreground";
                        LowerBody.GetComponent<SpriteRenderer>().sortingOrder = 2;
                        LowerArmFront.GetComponent<SpriteRenderer>().sortingOrder = 3;

                        LowerBody.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Kleiner/Lower Body Skin.png"), ModAPI.LoadSprite("Sprites/Kleiner/Lower Body Flesh.png"), ModAPI.LoadSprite("Sprites/Kleiner/Lower Body Skeleton.png"), ModAPI.LoadSprite("Sprites/Kleiner/Lower Body Damage.png"));
                    }
                }
            );
            #endregion
            #region Arne Magnusson
            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Arne Magnusson" + ModTag,
                    NameToOrderByOverride = "h",
                    DescriptionOverride = "Dr. Arne Magnusson is the leader of White Forest. He is a grey-haired, stocky, Caucasian man who looks to be in his early sixties. He is a former member of the Black Mesa Science Team, one of the few survivors of the Black Mesa Incident, and an important orchestrator of the Resistance.",
                    CategoryOverride = ModAPI.FindCategory("Half Life 2 Characters Mod"),
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Magnusson.png", 5f),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Sprites/magnusson.png");

                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin);

                        if (Instance.transform.localScale.x > 0f)
                        {
                            Instance.transform.localScale = new Vector3(1.09f, 1.09f, 1f);
                        }
                        else
                        {
                            Instance.transform.localScale = new Vector3(-1.09f, 1.09f, 1f);
                        }

                        #region Limb List
                        GameObject Head = Instance.transform.Find("Head").gameObject;
                        GameObject UpperBody = Instance.transform.Find("Body/UpperBody").gameObject;
                        GameObject MiddleBody = Instance.transform.Find("Body/MiddleBody").gameObject;
                        GameObject LowerBody = Instance.transform.Find("Body/LowerBody").gameObject;
                        GameObject LowerArm = Instance.transform.Find("BackArm/LowerArm").gameObject;
                        GameObject UpperArm = Instance.transform.Find("BackArm/UpperArm").gameObject;
                        GameObject LowerArmFront = Instance.transform.Find("FrontArm/LowerArmFront").gameObject;
                        GameObject UpperArmFront = Instance.transform.Find("FrontArm/UpperArmFront").gameObject;
                        #endregion

                        LowerBody.GetComponent<SpriteRenderer>().sortingLayerName = "Foreground";
                        LowerBody.GetComponent<SpriteRenderer>().sortingOrder = 2;
                        LowerArmFront.GetComponent<SpriteRenderer>().sortingOrder = 3;
                    }
                }
            );
            #endregion
            #region Alyx Vance
            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Alyx Vance" + ModTag,
                    NameToOrderByOverride = "h",
                    DescriptionOverride = "Alyx Vance is the deuteragonist of Half-Life 2 and its Episodes and the titular protagonist of Half-Life: Alyx. A young woman in her mid-twenties, she is a prominent figure in the Resistance campaign against the rule of the Combine.",
                    CategoryOverride = ModAPI.FindCategory("Half Life 2 Characters Mod"),
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Alyx.png", 5f),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Sprites/Alyx/Skin.png");

                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin);

                        #region Limb List
                        GameObject Head = Instance.transform.Find("Head").gameObject;
                        GameObject UpperBody = Instance.transform.Find("Body/UpperBody").gameObject;
                        GameObject MiddleBody = Instance.transform.Find("Body/MiddleBody").gameObject;
                        GameObject LowerBody = Instance.transform.Find("Body/LowerBody").gameObject;
                        GameObject LowerArm = Instance.transform.Find("BackArm/LowerArm").gameObject;
                        GameObject UpperArm = Instance.transform.Find("BackArm/UpperArm").gameObject;
                        GameObject LowerArmFront = Instance.transform.Find("FrontArm/LowerArmFront").gameObject;
                        GameObject UpperArmFront = Instance.transform.Find("FrontArm/UpperArmFront").gameObject;
                        #endregion

                        if (Instance.transform.localScale.x > 0f)
                        {
                            Instance.transform.localScale = new Vector3(1.07f, 1.07f, 1f);
                        }
                        else
                        {
                            Instance.transform.localScale = new Vector3(-1.07f, 1.07f, 1f);
                        }

                        Head.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Alyx/Head Skin.png"), ModAPI.LoadSprite("Sprites/Alyx/Head Flesh.png"), ModAPI.LoadSprite("Sprites/Alyx/Head Skeleton.png"), ModAPI.LoadSprite("Sprites/Alyx/Head Damage.png"));
                    }
                }
            );
            #endregion
            #region Eli Vance
            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Eli Vance" + ModTag,
                    NameToOrderByOverride = "h",
                    DescriptionOverride = "Dr. Eli Vance is a former Black Mesa researcher and physicist. Decades after the failed experiment, he has become one of the key leaders in a fight against the Combine’s totalitarian rule. He wears a prosthetic leg to replace his left leg beneath the knees.",
                    CategoryOverride = ModAPI.FindCategory("Half Life 2 Characters Mod"),
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Eli.png", 5f),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Sprites/Eli/Skin.png");

                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin);

                        if (Instance.transform.localScale.x > 0f)
                        {
                            Instance.transform.localScale = new Vector3(1.10f, 1.10f, 1f);
                        }
                        else
                        {
                            Instance.transform.localScale = new Vector3(-1.10f, 1.10f, 1f);
                        }

                        #region Limb List
                        GameObject Head = Instance.transform.Find("Head").gameObject;
                        GameObject UpperBody = Instance.transform.Find("Body/UpperBody").gameObject;
                        GameObject MiddleBody = Instance.transform.Find("Body/MiddleBody").gameObject;
                        GameObject LowerBody = Instance.transform.Find("Body/LowerBody").gameObject;
                        GameObject LowerArm = Instance.transform.Find("BackArm/LowerArm").gameObject;
                        GameObject UpperArm = Instance.transform.Find("BackArm/UpperArm").gameObject;
                        GameObject LowerArmFront = Instance.transform.Find("FrontArm/LowerArmFront").gameObject;
                        GameObject UpperArmFront = Instance.transform.Find("FrontArm/UpperArmFront").gameObject;
                        GameObject LowerLeg = Instance.transform.Find("BackLeg/LowerLeg").gameObject;
                        GameObject UpperLeg = Instance.transform.Find("BackLeg/UpperLeg").gameObject;
                        GameObject Foot = Instance.transform.Find("BackLeg/Foot").gameObject;
                        GameObject FrontLowerLeg = Instance.transform.Find("FrontLeg/LowerLegFront").gameObject;
                        GameObject FrontUpperLeg = Instance.transform.Find("FrontLeg/UpperLegFront").gameObject;
                        GameObject FrontFoot = Instance.transform.Find("FrontLeg/FootFront").gameObject;
                        GameObject LegOffset = Instance.transform.Find("BackLeg").gameObject;
                        GameObject FrontLegOffset = Instance.transform.Find("FrontLeg").gameObject;
                        GameObject ArmOffset = Instance.transform.Find("BackArm").gameObject;
                        GameObject FrontArmOffset = Instance.transform.Find("FrontArm").gameObject;
                        #endregion

                        LowerLeg.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Eli/Leg Skin.png"), ModAPI.LoadSprite("Sprites/Eli/Leg Flesh.png"), ModAPI.LoadSprite("Sprites/Eli/Leg Skeleton.png"), ModAPI.LoadSprite("Sprites/Eli/Leg Damage.png"));
                        LowerLeg.GetComponent<LimbBehaviour>().SetLimbEffectColor("_ThirdBruiseColor", 18, 24, 34);
                        LowerLeg.GetComponent<LimbBehaviour>().SetLimbEffectColor("_BruiseColor", 18, 24, 34);
                        LowerLeg.GetComponent<LimbBehaviour>().SetLimbEffectColor("_Zombie", 18, 24, 34);
                        LowerLeg.GetComponent<LimbBehaviour>().SetLimbEffectColor("_BloodColor", 18, 24, 34);
                        LowerLeg.GetComponent<LimbBehaviour>().SetLimbEffectColor("_SecondBruiseColor", 18, 24, 34);
                        LowerLeg.GetOrAddComponent<AlwaysGoodBloodFlow>();
                        LowerLeg.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Metal");

                        LowerLeg.GetComponent<BoxCollider2D>().offset = new Vector2(-0.00141394138f, -0.0444957912f);
                        LowerLeg.GetComponent<BoxCollider2D>().size = new Vector2(0.142357588f, 0.482437074f);

                        Foot.SetActive(false);

                        person.Limbs = Instance.GetComponentsInChildren<LimbBehaviour>();
                    }
                }
            );
            #endregion
            #region Odessa Cubbage
            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Odessa Cubbage" + ModTag,
                    NameToOrderByOverride = "h",
                    DescriptionOverride = "Colonel Odessa Cubbage is a Resistance leader situated at the eponymous outpost, New Little Odessa. When Gordon Freeman passes through on his journey along the Coast, Cubbage can be seen in the main building's basement explaining the use of the RPG to a group of gathered rebels, before handing the weapon to Gordon for use in an ensuing Gunship battle.",
                    CategoryOverride = ModAPI.FindCategory("Half Life 2 Characters Mod"),
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Odessa.png", 5f),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Sprites/Odessa/Skin.png");

                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin);

                        #region Limb List
                        GameObject Head = Instance.transform.Find("Head").gameObject;
                        GameObject UpperBody = Instance.transform.Find("Body/UpperBody").gameObject;
                        GameObject MiddleBody = Instance.transform.Find("Body/MiddleBody").gameObject;
                        GameObject LowerBody = Instance.transform.Find("Body/LowerBody").gameObject;
                        GameObject LowerArm = Instance.transform.Find("BackArm/LowerArm").gameObject;
                        GameObject UpperArm = Instance.transform.Find("BackArm/UpperArm").gameObject;
                        GameObject LowerArmFront = Instance.transform.Find("FrontArm/LowerArmFront").gameObject;
                        GameObject UpperArmFront = Instance.transform.Find("FrontArm/UpperArmFront").gameObject;
                        #endregion

                        if (Instance.transform.localScale.x > 0f)
                        {
                            Instance.transform.localScale = new Vector3(1.10f, 1.1f, 1f);
                        }
                        else
                        {
                            Instance.transform.localScale = new Vector3(-1.1f, 1.1f, 1f);
                        }

                        Head.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Odessa/Head Skin.png"), ModAPI.LoadSprite("Sprites/Odessa/Head Flesh.png"), ModAPI.LoadSprite("Sprites/Odessa/Head Skeleton.png"), ModAPI.LoadSprite("Sprites/Odessa/Head Damage.png"));
                    }
                }
            );
            #endregion
            #region Grigori
            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Father Grigori" + ModTag,
                    NameToOrderByOverride = "h",
                    DescriptionOverride = "Father Grigori is the only known surviving occupant of Ravenholm during the events of Half-Life 2. He appears to be eccentric and possibly mentally unstable, but is generally friendly. He's presumedly an Eastern Orthodox Priest.",
                    CategoryOverride = ModAPI.FindCategory("Half Life 2 Characters Mod"),
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Grigori.png", 5f),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Sprites/Grigori.png");

                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin);

                        if (Instance.transform.localScale.x > 0f)
                        {
                            Instance.transform.localScale = new Vector3(1.06f, 1.06f, 1f);
                        }
                        else
                        {
                            Instance.transform.localScale = new Vector3(-1.06f, 1.06f, 1f);
                        }
                    }
                }
            );
            #endregion
            #region Dr. Judith Mossman
            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Dr. Judith Mossman" + ModTag,
                    NameToOrderByOverride = "h",
                    DescriptionOverride = "Dr. Judith Mossman is a scientist who plays an integral role as the personal assistant for Dr. Wallace Breen, effectually becoming his second in command.",
                    CategoryOverride = ModAPI.FindCategory("Half Life 2 Characters Mod"),
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Judith.png", 5f),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Sprites/Judith/Skin.png");

                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin);

                        #region Limb List
                        GameObject Head = Instance.transform.Find("Head").gameObject;
                        GameObject UpperBody = Instance.transform.Find("Body/UpperBody").gameObject;
                        GameObject MiddleBody = Instance.transform.Find("Body/MiddleBody").gameObject;
                        GameObject LowerBody = Instance.transform.Find("Body/LowerBody").gameObject;
                        GameObject LowerArm = Instance.transform.Find("BackArm/LowerArm").gameObject;
                        GameObject UpperArm = Instance.transform.Find("BackArm/UpperArm").gameObject;
                        GameObject LowerArmFront = Instance.transform.Find("FrontArm/LowerArmFront").gameObject;
                        GameObject UpperArmFront = Instance.transform.Find("FrontArm/UpperArmFront").gameObject;
                        #endregion

                        if (Instance.transform.localScale.x > 0f)
                        {
                            Instance.transform.localScale = new Vector3(1.08f, 1.08f, 1f);
                        }
                        else
                        {
                            Instance.transform.localScale = new Vector3(-1.08f, 1.08f, 1f);
                        }

                        Head.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Judith/Head Skin.png"), ModAPI.LoadSprite("Sprites/Judith/Head Flesh.png"), ModAPI.LoadSprite("Sprites/Judith/Head Skeleton.png"), ModAPI.LoadSprite("Sprites/Judith/Head Damage.png"));
                    }
                }
            );
            #endregion
            #region Dr. Wallace Breen
            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Dr. Wallace Breen" + ModTag,
                    NameToOrderByOverride = "h",
                    DescriptionOverride = "Dr. Wallace Breen was Black Mesa's, then later, after negotiating the surrender of Earth and ending the Seven Hour War, Earth’s Administrator. \n\nHe will ask you to LEAVE THE FUCKING CITY NOW!",
                    CategoryOverride = ModAPI.FindCategory("Half Life 2 Characters Mod"),
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Dr Breen.png", 5f),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Sprites/Dr Breen.png");

                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin);

                        if (Instance.transform.localScale.x > 0f)
                        {
                            Instance.transform.localScale = new Vector3(1.10f, 1.1f, 1f);
                        }
                        else
                        {
                            Instance.transform.localScale = new Vector3(-1.1f, 1.1f, 1f);
                        }
                    }
                }
            );
            #endregion
            #region Gman
            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "G-Man" + ModTag,
                    NameToOrderByOverride = "h",
                    DescriptionOverride = "The G-Man is an enigmatic and mysterious character that appears in nearly every title of the Half-Life series. Referred to as a \"sinister inter-dimensional bureaucrat\", he is known to display peculiar behavior and wield reality-bending powers.",
                    CategoryOverride = ModAPI.FindCategory("Half Life 2 Characters Mod"),
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Gman.png", 5f),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Sprites/Gman/Skin.png");

                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin);

                        if (Instance.transform.localScale.x > 0f)
                        {
                            Instance.transform.localScale = new Vector3(1.09f, 1.09f, 1f);
                        }
                        else
                        {
                            Instance.transform.localScale = new Vector3(-1.09f, 1.09f, 1f);
                        }

                        #region Limb List
                        GameObject Head = Instance.transform.Find("Head").gameObject;
                        GameObject UpperBody = Instance.transform.Find("Body/UpperBody").gameObject;
                        GameObject MiddleBody = Instance.transform.Find("Body/MiddleBody").gameObject;
                        GameObject LowerBody = Instance.transform.Find("Body/LowerBody").gameObject;
                        GameObject LowerArm = Instance.transform.Find("BackArm/LowerArm").gameObject;
                        GameObject UpperArm = Instance.transform.Find("BackArm/UpperArm").gameObject;
                        GameObject LowerArmFront = Instance.transform.Find("FrontArm/LowerArmFront").gameObject;
                        GameObject UpperArmFront = Instance.transform.Find("FrontArm/UpperArmFront").gameObject;
                        #endregion

                        Head.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Gman/Head Skin.png"), ModAPI.LoadSprite("Sprites/Gman/Head Flesh.png"), ModAPI.LoadSprite("Sprites/Gman/Head Skeleton.png"), ModAPI.LoadSprite("Sprites/Gman/Head Damage.png"));
                    }
                }
            );
            #endregion
            #region Citizen
            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Citizen" + ModTag,
                    NameToOrderByOverride = "h",
                    DescriptionOverride = "Citizens are humans living under Combine rule, after the Seven Hour War and subsequent Combine occupation.",
                    CategoryOverride = ModAPI.FindCategory("Half Life 2 Characters Mod"),
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Citizen.png", 5f),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Sprites/Citizen.png");

                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin);
                    }
                }
            );
            #endregion
            #region rEFUGEE
            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Refugee" + ModTag,
                    NameToOrderByOverride = "h",
                    DescriptionOverride = "Same thing as citizen, but different texture. \nCitizens are humans living under Combine rule, after the Seven Hour War and subsequent Combine occupation.",
                    CategoryOverride = ModAPI.FindCategory("Half Life 2 Characters Mod"),
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Refugee.png", 5f),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Sprites/Refugee.png");

                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin);
                    }
                }
            );
            #endregion
            #region Rebel Blue
            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Rebel 1" + ModTag,
                    NameToOrderByOverride = "h",
                    DescriptionOverride = "Part of Resistance, which is a loose, covert rebel network of humans and Vortigaunts with the shared goal of defeating the Combine and restoring their freedom.",
                    CategoryOverride = ModAPI.FindCategory("Half Life 2 Characters Mod"),
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Rebel Blue.png", 5f),
                    AfterSpawn = (Instance) =>
                    {

                        var skin = ModAPI.LoadTexture("Sprites/Rebel Blue/Skin.png");

                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin);
                        person.RandomisedSize = false;

                        #region Limb List
                        GameObject Head = Instance.transform.Find("Head").gameObject;
                        GameObject UpperBody = Instance.transform.Find("Body/UpperBody").gameObject;
                        GameObject MiddleBody = Instance.transform.Find("Body/MiddleBody").gameObject;
                        GameObject LowerBody = Instance.transform.Find("Body/LowerBody").gameObject;
                        GameObject LowerArm = Instance.transform.Find("BackArm/LowerArm").gameObject;
                        GameObject UpperArm = Instance.transform.Find("BackArm/UpperArm").gameObject;
                        GameObject LowerArmFront = Instance.transform.Find("FrontArm/LowerArmFront").gameObject;
                        GameObject UpperArmFront = Instance.transform.Find("FrontArm/UpperArmFront").gameObject;
                        #endregion

                        UpperBody.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Rubber");
                        UpperBody.GetComponent<SkinMaterialHandler>().intensityMultiplier = 1f / 4f;
                        MiddleBody.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Rubber");
                        MiddleBody.GetComponent<SkinMaterialHandler>().intensityMultiplier = 1f / 4f;
                        LowerBody.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Rubber");
                        LowerBody.GetComponent<SkinMaterialHandler>().intensityMultiplier = 1f / 4f;

                        Head.GetComponent<SpriteRenderer>().sortingLayerName = "Default";

                        LowerBody.GetComponent<SpriteRenderer>().sortingLayerName = "Foreground";
                        LowerBody.GetComponent<SpriteRenderer>().sortingOrder = 2;
                        LowerArmFront.GetComponent<SpriteRenderer>().sortingOrder = 3;

                        UpperBody.GetComponent<SpriteRenderer>().sortingOrder = 2;

                        Head.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Rebel Blue/Head Skin.png"), ModAPI.LoadSprite("Sprites/Rebel Blue/Head Flesh.png"), ModAPI.LoadSprite("Sprites/Rebel Blue/Head Skeleton.png"), ModAPI.LoadSprite("Sprites/Rebel Blue/Head Damage.png"));
                        UpperBody.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Rebel Blue/Upper Body Skin.png"), ModAPI.LoadSprite("Sprites/Rebel Blue/Upper Body Flesh.png"), ModAPI.LoadSprite("Sprites/Rebel Blue/Upper Body Skeleton.png"), ModAPI.LoadSprite("Sprites/Rebel Blue/Upper Body Damage.png"));
                        MiddleBody.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Rebel Blue/Middle Body Skin.png"), ModAPI.LoadSprite("Sprites/Rebel Blue/Middle Body Flesh.png"), ModAPI.LoadSprite("Sprites/Rebel Blue/Middle Body Skeleton.png"), ModAPI.LoadSprite("Sprites/Rebel Blue/Middle Body Damage.png"));
                        LowerBody.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Rebel Blue/Lower Body Skin.png"), ModAPI.LoadSprite("Sprites/Rebel Blue/Lower Body Flesh.png"), ModAPI.LoadSprite("Sprites/Rebel Blue/Lower Body Skeleton.png"), ModAPI.LoadSprite("Sprites/Rebel Blue/Lower Body Damage.png"));
                    }
                }
            );
            #endregion
            #region Rebel Green
            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Rebel 2" + ModTag,
                    NameToOrderByOverride = "h",
                    DescriptionOverride = "Part of Resistance, which is a loose, covert rebel network of humans and Vortigaunts with the shared goal of defeating the Combine and restoring their freedom.",
                    CategoryOverride = ModAPI.FindCategory("Half Life 2 Characters Mod"),
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Rebel Green.png", 5f),
                    AfterSpawn = (Instance) =>
                    {

                        var skin = ModAPI.LoadTexture("Sprites/Rebel Green/Skin.png");

                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin);
                        person.RandomisedSize = false;

                        #region Limb List
                        GameObject Head = Instance.transform.Find("Head").gameObject;
                        GameObject UpperBody = Instance.transform.Find("Body/UpperBody").gameObject;
                        GameObject MiddleBody = Instance.transform.Find("Body/MiddleBody").gameObject;
                        GameObject LowerBody = Instance.transform.Find("Body/LowerBody").gameObject;
                        GameObject LowerArm = Instance.transform.Find("BackArm/LowerArm").gameObject;
                        GameObject UpperArm = Instance.transform.Find("BackArm/UpperArm").gameObject;
                        GameObject LowerArmFront = Instance.transform.Find("FrontArm/LowerArmFront").gameObject;
                        GameObject UpperArmFront = Instance.transform.Find("FrontArm/UpperArmFront").gameObject;
                        #endregion

                        UpperBody.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Rubber");
                        UpperBody.GetComponent<SkinMaterialHandler>().intensityMultiplier = 1f / 4f;
                        MiddleBody.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Rubber");
                        MiddleBody.GetComponent<SkinMaterialHandler>().intensityMultiplier = 1f / 4f;
                        LowerBody.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Rubber");
                        LowerBody.GetComponent<SkinMaterialHandler>().intensityMultiplier = 1f / 4f;

                        Head.GetComponent<SpriteRenderer>().sortingLayerName = "Default";

                        LowerBody.GetComponent<SpriteRenderer>().sortingLayerName = "Foreground";
                        LowerBody.GetComponent<SpriteRenderer>().sortingOrder = 2;
                        LowerArmFront.GetComponent<SpriteRenderer>().sortingOrder = 3;

                        UpperBody.GetComponent<SpriteRenderer>().sortingOrder = 2;

                        Head.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Rebel Green/Head Skin.png"), ModAPI.LoadSprite("Sprites/Rebel Green/Head Flesh.png"), ModAPI.LoadSprite("Sprites/Rebel Green/Head Skeleton.png"), ModAPI.LoadSprite("Sprites/Rebel Green/Head Damage.png"));
                        UpperBody.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Rebel Green/Upper Body Skin.png"), ModAPI.LoadSprite("Sprites/Rebel Green/Upper Body Flesh.png"), ModAPI.LoadSprite("Sprites/Rebel Green/Upper Body Skeleton.png"), ModAPI.LoadSprite("Sprites/Rebel Green/Upper Body Damage.png"));
                        MiddleBody.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Rebel Green/Middle Body Skin.png"), ModAPI.LoadSprite("Sprites/Rebel Green/Middle Body Flesh.png"), ModAPI.LoadSprite("Sprites/Rebel Green/Middle Body Skeleton.png"), ModAPI.LoadSprite("Sprites/Rebel Green/Middle Body Damage.png"));
                        LowerBody.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Rebel Green/Lower Body Skin.png"), ModAPI.LoadSprite("Sprites/Rebel Green/Lower Body Flesh.png"), ModAPI.LoadSprite("Sprites/Rebel Green/Lower Body Skeleton.png"), ModAPI.LoadSprite("Sprites/Rebel Green/Lower Body Damage.png"));
                    }
                }
            );
            #endregion
            #region Medic Grey
            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Medic 1" + ModTag,
                    NameToOrderByOverride = "h",
                    DescriptionOverride = "Part of Resistance, which is a loose, covert rebel network of humans and Vortigaunts with the shared goal of defeating the Combine and restoring their freedom.",
                    CategoryOverride = ModAPI.FindCategory("Half Life 2 Characters Mod"),
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Medic Grey.png", 5f),
                    AfterSpawn = (Instance) =>
                    {

                        var skin = ModAPI.LoadTexture("Sprites/Medic Grey/Skin.png");

                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin);
                        person.RandomisedSize = false;

                        #region Limb List
                        GameObject Head = Instance.transform.Find("Head").gameObject;
                        GameObject UpperBody = Instance.transform.Find("Body/UpperBody").gameObject;
                        GameObject MiddleBody = Instance.transform.Find("Body/MiddleBody").gameObject;
                        GameObject LowerBody = Instance.transform.Find("Body/LowerBody").gameObject;
                        GameObject LowerArm = Instance.transform.Find("BackArm/LowerArm").gameObject;
                        GameObject UpperArm = Instance.transform.Find("BackArm/UpperArm").gameObject;
                        GameObject LowerArmFront = Instance.transform.Find("FrontArm/LowerArmFront").gameObject;
                        GameObject UpperArmFront = Instance.transform.Find("FrontArm/UpperArmFront").gameObject;
                        #endregion

                        UpperBody.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Rubber");
                        UpperBody.GetComponent<SkinMaterialHandler>().intensityMultiplier = 1f / 4f;
                        MiddleBody.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Rubber");
                        MiddleBody.GetComponent<SkinMaterialHandler>().intensityMultiplier = 1f / 4f;
                        LowerBody.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Rubber");
                        LowerBody.GetComponent<SkinMaterialHandler>().intensityMultiplier = 1f / 4f;

                        Head.GetComponent<SpriteRenderer>().sortingLayerName = "Default";

                        LowerBody.GetComponent<SpriteRenderer>().sortingLayerName = "Foreground";
                        LowerBody.GetComponent<SpriteRenderer>().sortingOrder = 2;
                        LowerArmFront.GetComponent<SpriteRenderer>().sortingOrder = 3;

                        UpperBody.GetComponent<SpriteRenderer>().sortingOrder = 2;

                        UpperBody.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Medic Grey/Upper Body Skin.png"), ModAPI.LoadSprite("Sprites/Medic Grey/Upper Body Flesh.png"), ModAPI.LoadSprite("Sprites/Medic Grey/Upper Body Skeleton.png"), ModAPI.LoadSprite("Sprites/Medic Grey/Upper Body Damage.png"));
                        MiddleBody.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Medic Grey/Middle Body Skin.png"), ModAPI.LoadSprite("Sprites/Medic Grey/Middle Body Flesh.png"), ModAPI.LoadSprite("Sprites/Medic Grey/Middle Body Skeleton.png"), ModAPI.LoadSprite("Sprites/Medic Grey/Middle Body Damage.png"));
                        LowerBody.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Medic Grey/Lower Body Skin.png"), ModAPI.LoadSprite("Sprites/Medic Grey/Lower Body Flesh.png"), ModAPI.LoadSprite("Sprites/Medic Grey/Lower Body Skeleton.png"), ModAPI.LoadSprite("Sprites/Medic Grey/Lower Body Damage.png"));
                    }
                }
            );
            #endregion
            #region Medic White
            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Medic 2" + ModTag,
                    NameToOrderByOverride = "h",
                    DescriptionOverride = "Part of Resistance, which is a loose, covert rebel network of humans and Vortigaunts with the shared goal of defeating the Combine and restoring their freedom.",
                    CategoryOverride = ModAPI.FindCategory("Half Life 2 Characters Mod"),
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Medic White.png", 5f),
                    AfterSpawn = (Instance) =>
                    {

                        var skin = ModAPI.LoadTexture("Sprites/Medic White/Skin.png");

                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin);
                        person.RandomisedSize = false;

                        #region Limb List
                        GameObject Head = Instance.transform.Find("Head").gameObject;
                        GameObject UpperBody = Instance.transform.Find("Body/UpperBody").gameObject;
                        GameObject MiddleBody = Instance.transform.Find("Body/MiddleBody").gameObject;
                        GameObject LowerBody = Instance.transform.Find("Body/LowerBody").gameObject;
                        GameObject LowerArm = Instance.transform.Find("BackArm/LowerArm").gameObject;
                        GameObject UpperArm = Instance.transform.Find("BackArm/UpperArm").gameObject;
                        GameObject LowerArmFront = Instance.transform.Find("FrontArm/LowerArmFront").gameObject;
                        GameObject UpperArmFront = Instance.transform.Find("FrontArm/UpperArmFront").gameObject;
                        #endregion

                        UpperBody.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Rubber");
                        UpperBody.GetComponent<SkinMaterialHandler>().intensityMultiplier = 1f / 4f;
                        MiddleBody.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Rubber");
                        MiddleBody.GetComponent<SkinMaterialHandler>().intensityMultiplier = 1f / 4f;
                        LowerBody.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Rubber");
                        LowerBody.GetComponent<SkinMaterialHandler>().intensityMultiplier = 1f / 4f;

                        Head.GetComponent<SpriteRenderer>().sortingLayerName = "Default";

                        LowerBody.GetComponent<SpriteRenderer>().sortingLayerName = "Foreground";
                        LowerBody.GetComponent<SpriteRenderer>().sortingOrder = 2;
                        LowerArmFront.GetComponent<SpriteRenderer>().sortingOrder = 3;

                        UpperBody.GetComponent<SpriteRenderer>().sortingOrder = 2;

                        UpperBody.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Medic White/Upper Body Skin.png"), ModAPI.LoadSprite("Sprites/Medic White/Upper Body Flesh.png"), ModAPI.LoadSprite("Sprites/Medic White/Upper Body Skeleton.png"), ModAPI.LoadSprite("Sprites/Medic White/Upper Body Damage.png"));
                        MiddleBody.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Medic White/Middle Body Skin.png"), ModAPI.LoadSprite("Sprites/Medic White/Middle Body Flesh.png"), ModAPI.LoadSprite("Sprites/Medic White/Middle Body Skeleton.png"), ModAPI.LoadSprite("Sprites/Medic White/Middle Body Damage.png"));
                        LowerBody.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Medic White/Lower Body Skin.png"), ModAPI.LoadSprite("Sprites/Medic White/Lower Body Flesh.png"), ModAPI.LoadSprite("Sprites/Medic White/Lower Body Skeleton.png"), ModAPI.LoadSprite("Sprites/Medic White/Lower Body Damage.png"));
                    }
                }
            );
            #endregion
            #region CCP
            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Combine Civil Protection" + ModTag,
                    NameToOrderByOverride = "h",
                    DescriptionOverride = "Also known as the \"metro cops\" and \"CPs\", is the police force responsible for law enforcement of all Combine citizens on Earth, including City 17.",
                    CategoryOverride = ModAPI.FindCategory("Half Life 2 Characters Mod"),
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/CCP.png", 5f),
                    AfterSpawn = (Instance) =>
                    {

                        var skin = ModAPI.LoadTexture("Sprites/CCP/Skin.png");

                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin);
                        person.RandomisedSize = false;

                        var prop = ModAPI.FindPhysicalProperties("Metal");

                        foreach (var body in person.Limbs)
                        {
                            body.DiscomfortingHeatTemperature = 10000000000f;
                            body.ImpactDamageMultiplier = 0f;
                            body.ImpactPainMultiplier = 0f;
                            body.RegenerationSpeed = 8f;
                            body.Health = 100f;
                            body.InitialHealth = 100f;
                            body.BaseStrength = 6f;
                            body.BreakingThreshold = 6f;
                            body.HasBrain = false;
                            body.HasLungs = false;
                        }

                        if (Instance.transform.localScale.x > 0f)
                        {
                            Instance.transform.localScale = new Vector3(1.11f, 1.11f, 1f);
                        }
                        else
                        {
                            Instance.transform.localScale = new Vector3(-1.11f, 1.11f, 1f);
                        }

                        #region Limb List
                        GameObject Head = Instance.transform.Find("Head").gameObject;
                        GameObject UpperBody = Instance.transform.Find("Body/UpperBody").gameObject;
                        GameObject MiddleBody = Instance.transform.Find("Body/MiddleBody").gameObject;
                        GameObject LowerBody = Instance.transform.Find("Body/LowerBody").gameObject;
                        GameObject LowerArm = Instance.transform.Find("BackArm/LowerArm").gameObject;
                        GameObject UpperArm = Instance.transform.Find("BackArm/UpperArm").gameObject;
                        GameObject LowerArmFront = Instance.transform.Find("FrontArm/LowerArmFront").gameObject;
                        GameObject UpperArmFront = Instance.transform.Find("FrontArm/UpperArmFront").gameObject;
                        #endregion

                        UpperBody.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Metal");
                        UpperBody.GetOrAddComponent<AlwaysGoodBloodFlow>();
                        UpperBody.GetComponent<SkinMaterialHandler>().intensityMultiplier = 1f / 4f;
                        MiddleBody.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Metal");
                        MiddleBody.GetOrAddComponent<AlwaysGoodBloodFlow>();
                        MiddleBody.GetComponent<SkinMaterialHandler>().intensityMultiplier = 1f / 4f;
                        LowerBody.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Metal");
                        LowerBody.GetOrAddComponent<AlwaysGoodBloodFlow>();
                        LowerBody.GetComponent<SkinMaterialHandler>().intensityMultiplier = 1f / 4f;

                        Head.GetComponent<SpriteRenderer>().sortingLayerName = "Default";
                        DetectDeadLimbAndPlaySound DeathSound = Head.GetOrAddComponent<DetectDeadLimbAndPlaySound>();
                        DeathSound.limb = Head.GetComponent<LimbBehaviour>();
                        DeathSound.clip = new AudioClip[]
                        {
                            ModAPI.LoadSound("SFX/Metrocop Die/die1.wav"),
                            ModAPI.LoadSound("SFX/Metrocop Die/die2.wav"),
                            ModAPI.LoadSound("SFX/Metrocop Die/die3.wav"),
                            ModAPI.LoadSound("SFX/Metrocop Die/die4.wav"),
                        };

                        Head.GetComponent<SkinMaterialHandler>().intensityMultiplier = 1f / 4f;
                        Head.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Metal");
                        Head.GetOrAddComponent<AlwaysGoodBloodFlow>();

                        LowerBody.GetComponent<SpriteRenderer>().sortingLayerName = "Foreground";
                        LowerBody.GetComponent<SpriteRenderer>().sortingOrder = 2;
                        LowerArmFront.GetComponent<SpriteRenderer>().sortingOrder = 3;

                        UpperBody.GetComponent<SpriteRenderer>().sortingOrder = 2;

                        Head.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/CCP/Head Skin.png"), ModAPI.LoadSprite("Sprites/CCP/Head Flesh.png"), ModAPI.LoadSprite("Sprites/CCP/Head Skeleton.png"), ModAPI.LoadSprite("Sprites/CCP/Head Damage.png"));
                        UpperBody.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/CCP/Upper Body Skin.png"), ModAPI.LoadSprite("Sprites/CCP/Upper Body Flesh.png"), ModAPI.LoadSprite("Sprites/CCP/Upper Body Skeleton.png"), ModAPI.LoadSprite("Sprites/CCP/Upper Body Damage.png"));
                        MiddleBody.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/CCP/Middle Body Skin.png"), ModAPI.LoadSprite("Sprites/CCP/Middle Body Flesh.png"), ModAPI.LoadSprite("Sprites/CCP/Middle Body Skeleton.png"), ModAPI.LoadSprite("Sprites/CCP/Middle Body Damage.png"));
                        LowerBody.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/CCP/Lower Body Skin.png"), ModAPI.LoadSprite("Sprites/CCP/Lower Body Flesh.png"), ModAPI.LoadSprite("Sprites/CCP/Lower Body Skeleton.png"), ModAPI.LoadSprite("Sprites/CCP/Lower Body Damage.png"));
                    }
                }
            );
            #endregion
            #region OTA
            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Overwatch Soldier" + ModTag,
                    NameToOrderByOverride = "h",
                    DescriptionOverride = "Overwatch Soldier, referred to as Stabilization Delegates by the Overwatch Voice, are the standard transhuman infantry units of the Combine Overwatch, composing the backbone of the Combine's military presence on Earth.",
                    CategoryOverride = ModAPI.FindCategory("Half Life 2 Characters Mod"),
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/OTA.png", 5f),
                    AfterSpawn = (Instance) =>
                    {

                        var skin = ModAPI.LoadTexture("Sprites/OTA/Skin.png");

                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin);
                        person.RandomisedSize = false;

                        var prop = ModAPI.FindPhysicalProperties("Metal");

                        foreach (var body in person.Limbs)
                        {
                            body.DiscomfortingHeatTemperature = 10000000000f;
                            body.ImpactDamageMultiplier = 0f;
                            body.ImpactPainMultiplier = 0f;
                            body.RegenerationSpeed = 8f;
                            body.Health = 145f;
                            body.InitialHealth = 145f;
                            body.BaseStrength = 7.25f;
                            body.BreakingThreshold = 7.5f;
                            body.HasBrain = false;
                            body.HasLungs = false;
                        }

                        if (Instance.transform.localScale.x > 0f)
                        {
                            Instance.transform.localScale = new Vector3(1.11f, 1.11f, 1f);
                        }
                        else
                        {
                            Instance.transform.localScale = new Vector3(-1.11f, 1.11f, 1f);
                        }

                        #region Limb List
                        GameObject Head = Instance.transform.Find("Head").gameObject;
                        GameObject UpperBody = Instance.transform.Find("Body/UpperBody").gameObject;
                        GameObject MiddleBody = Instance.transform.Find("Body/MiddleBody").gameObject;
                        GameObject LowerBody = Instance.transform.Find("Body/LowerBody").gameObject;
                        GameObject LowerArm = Instance.transform.Find("BackArm/LowerArm").gameObject;
                        GameObject UpperArm = Instance.transform.Find("BackArm/UpperArm").gameObject;
                        GameObject LowerArmFront = Instance.transform.Find("FrontArm/LowerArmFront").gameObject;
                        GameObject UpperArmFront = Instance.transform.Find("FrontArm/UpperArmFront").gameObject;
                        #endregion

                        UpperBody.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Metal");
                        UpperBody.GetOrAddComponent<AlwaysGoodBloodFlow>();
                        UpperBody.GetComponent<SkinMaterialHandler>().intensityMultiplier = 1f / 4f;
                        MiddleBody.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Metal");
                        MiddleBody.GetOrAddComponent<AlwaysGoodBloodFlow>();
                        MiddleBody.GetComponent<SkinMaterialHandler>().intensityMultiplier = 1f / 4f;
                        LowerBody.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Metal");
                        LowerBody.GetOrAddComponent<AlwaysGoodBloodFlow>();
                        LowerBody.GetComponent<SkinMaterialHandler>().intensityMultiplier = 1f / 4f;

                        Head.GetComponent<SkinMaterialHandler>().intensityMultiplier = 1f / 4f;
                        Head.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Metal");
                        Head.GetOrAddComponent<AlwaysGoodBloodFlow>();
                        DetectDeadLimbAndPlaySound DeathSound = Head.GetOrAddComponent<DetectDeadLimbAndPlaySound>();
                        DeathSound.limb = Head.GetComponent<LimbBehaviour>();
                        DeathSound.clip = new AudioClip[]
                        {
                            ModAPI.LoadSound("SFX/Combine Die/die1.wav"),
                            ModAPI.LoadSound("SFX/Combine Die/die2.wav"),
                            ModAPI.LoadSound("SFX/Combine Die/die3.wav"),
                        };

                        Head.GetComponent<SpriteRenderer>().sortingLayerName = "Default";

                        LowerBody.GetComponent<SpriteRenderer>().sortingLayerName = "Foreground";
                        LowerBody.GetComponent<SpriteRenderer>().sortingOrder = 2;
                        LowerArmFront.GetComponent<SpriteRenderer>().sortingOrder = 3;
                        UpperBody.GetComponent<SpriteRenderer>().sortingOrder = 2;

                        Head.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/OTA/Head Skin.png"), ModAPI.LoadSprite("Sprites/OTA/Head Flesh.png"), ModAPI.LoadSprite("Sprites/OTA/Head Skeleton.png"), ModAPI.LoadSprite("Sprites/OTA/Head Damage.png"));
                        UpperBody.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/OTA/Upper Body Skin.png"), ModAPI.LoadSprite("Sprites/OTA/Upper Body Flesh.png"), ModAPI.LoadSprite("Sprites/OTA/Upper Body Skeleton.png"), ModAPI.LoadSprite("Sprites/OTA/Upper Body Damage.png"));
                        MiddleBody.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/OTA/Middle Body Skin.png"), ModAPI.LoadSprite("Sprites/OTA/Middle Body Flesh.png"), ModAPI.LoadSprite("Sprites/OTA/Middle Body Skeleton.png"), ModAPI.LoadSprite("Sprites/OTA/Middle Body Damage.png"));
                        LowerBody.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/OTA/Lower Body Skin.png"), ModAPI.LoadSprite("Sprites/OTA/Lower Body Flesh.png"), ModAPI.LoadSprite("Sprites/OTA/Lower Body Skeleton.png"), ModAPI.LoadSprite("Sprites/OTA/Lower Body Damage.png"));
                    }
                }
            );
            #endregion
            #region Guard
            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Prison Guard" + ModTag,
                    NameToOrderByOverride = "h",
                    DescriptionOverride = "Prison Guards are tasked with guarding and maintaining the Nova Prospekt facility. These guards are almost identical to standard Overwatch Soldiers.",
                    CategoryOverride = ModAPI.FindCategory("Half Life 2 Characters Mod"),
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Guard.png", 5f),
                    AfterSpawn = (Instance) =>
                    {

                        var skin = ModAPI.LoadTexture("Sprites/Guard/Skin.png");

                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin);
                        person.RandomisedSize = false;

                        var prop = ModAPI.FindPhysicalProperties("Metal");

                        foreach (var body in person.Limbs)
                        {
                            body.DiscomfortingHeatTemperature = 10000000000f;
                            body.ImpactDamageMultiplier = 0f;
                            body.ImpactPainMultiplier = 0f;
                            body.RegenerationSpeed = 8f;
                            body.Health = 135f;
                            body.InitialHealth = 135f;
                            body.BaseStrength = 7f;
                            body.BreakingThreshold = 7f;
                            body.HasBrain = false;
                            body.HasLungs = false;
                        }

                        if (Instance.transform.localScale.x > 0f)
                        {
                            Instance.transform.localScale = new Vector3(1.11f, 1.11f, 1f);
                        }
                        else
                        {
                            Instance.transform.localScale = new Vector3(-1.11f, 1.11f, 1f);
                        }

                        #region Limb List
                        GameObject Head = Instance.transform.Find("Head").gameObject;
                        GameObject UpperBody = Instance.transform.Find("Body/UpperBody").gameObject;
                        GameObject MiddleBody = Instance.transform.Find("Body/MiddleBody").gameObject;
                        GameObject LowerBody = Instance.transform.Find("Body/LowerBody").gameObject;
                        GameObject LowerArm = Instance.transform.Find("BackArm/LowerArm").gameObject;
                        GameObject UpperArm = Instance.transform.Find("BackArm/UpperArm").gameObject;
                        GameObject LowerArmFront = Instance.transform.Find("FrontArm/LowerArmFront").gameObject;
                        GameObject UpperArmFront = Instance.transform.Find("FrontArm/UpperArmFront").gameObject;
                        #endregion

                        UpperBody.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Metal");
                        UpperBody.GetOrAddComponent<AlwaysGoodBloodFlow>();
                        UpperBody.GetComponent<SkinMaterialHandler>().intensityMultiplier = 1f / 4f;
                        MiddleBody.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Metal");
                        MiddleBody.GetOrAddComponent<AlwaysGoodBloodFlow>();
                        MiddleBody.GetComponent<SkinMaterialHandler>().intensityMultiplier = 1f / 4f;
                        LowerBody.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Metal");
                        LowerBody.GetOrAddComponent<AlwaysGoodBloodFlow>();
                        LowerBody.GetComponent<SkinMaterialHandler>().intensityMultiplier = 1f / 4f;

                        Head.GetComponent<SkinMaterialHandler>().intensityMultiplier = 1f / 4f;
                        Head.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Metal");
                        Head.GetOrAddComponent<AlwaysGoodBloodFlow>();
                        DetectDeadLimbAndPlaySound DeathSound = Head.GetOrAddComponent<DetectDeadLimbAndPlaySound>();
                        DeathSound.limb = Head.GetComponent<LimbBehaviour>();
                        DeathSound.clip = new AudioClip[]
                        {
                            ModAPI.LoadSound("SFX/Combine Die/die1.wav"),
                            ModAPI.LoadSound("SFX/Combine Die/die2.wav"),
                            ModAPI.LoadSound("SFX/Combine Die/die3.wav"),
                        };

                        Head.GetComponent<SpriteRenderer>().sortingLayerName = "Default";

                        LowerBody.GetComponent<SpriteRenderer>().sortingLayerName = "Foreground";
                        LowerBody.GetComponent<SpriteRenderer>().sortingOrder = 2;
                        LowerArmFront.GetComponent<SpriteRenderer>().sortingOrder = 3;
                        UpperBody.GetComponent<SpriteRenderer>().sortingOrder = 2;

                        Head.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Guard/Head Skin 1.png"), ModAPI.LoadSprite("Sprites/Guard/Head Flesh.png"), ModAPI.LoadSprite("Sprites/Guard/Head Skeleton.png"), ModAPI.LoadSprite("Sprites/Guard/Head Damage.png"));
                        UpperBody.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Guard/Upper Body Skin.png"), ModAPI.LoadSprite("Sprites/Guard/Upper Body Flesh.png"), ModAPI.LoadSprite("Sprites/Guard/Upper Body Skeleton.png"), ModAPI.LoadSprite("Sprites/Guard/Upper Body Damage.png"));
                        MiddleBody.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Guard/Middle Body Skin.png"), ModAPI.LoadSprite("Sprites/Guard/Middle Body Flesh.png"), ModAPI.LoadSprite("Sprites/Guard/Middle Body Skeleton.png"), ModAPI.LoadSprite("Sprites/Guard/Middle Body Damage.png"));
                        LowerBody.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Guard/Lower Body Skin.png"), ModAPI.LoadSprite("Sprites/Guard/Lower Body Flesh.png"), ModAPI.LoadSprite("Sprites/Guard/Lower Body Skeleton.png"), ModAPI.LoadSprite("Sprites/Guard/Lower Body Damage.png"));
                    }
                }
            );
            #endregion
            #region Guard (Shotgunneer)
            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Prison Guard (Shotguneer)" + ModTag,
                    NameToOrderByOverride = "h",
                    DescriptionOverride = "These guards are almost identical to Prison Guards, only differences being that they wield Shotguns instead of AR2's and have red visor.",
                    CategoryOverride = ModAPI.FindCategory("Half Life 2 Characters Mod"),
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Guard Shotgun.png", 5f),
                    AfterSpawn = (Instance) =>
                    {

                        var skin = ModAPI.LoadTexture("Sprites/Guard/Skin.png");

                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin);
                        person.RandomisedSize = false;

                        var prop = ModAPI.FindPhysicalProperties("Metal");

                        foreach (var body in person.Limbs)
                        {
                            body.DiscomfortingHeatTemperature = 10000000000f;
                            body.ImpactDamageMultiplier = 0f;
                            body.ImpactPainMultiplier = 0f;
                            body.RegenerationSpeed = 8f;
                            body.Health = 135f;
                            body.InitialHealth = 135f;
                            body.BaseStrength = 7f;
                            body.BreakingThreshold = 7f;
                            body.HasBrain = false;
                            body.HasLungs = false;
                        }

                        if (Instance.transform.localScale.x > 0f)
                        {
                            Instance.transform.localScale = new Vector3(1.11f, 1.11f, 1f);
                        }
                        else
                        {
                            Instance.transform.localScale = new Vector3(-1.11f, 1.11f, 1f);
                        }

                        #region Limb List
                        GameObject Head = Instance.transform.Find("Head").gameObject;
                        GameObject UpperBody = Instance.transform.Find("Body/UpperBody").gameObject;
                        GameObject MiddleBody = Instance.transform.Find("Body/MiddleBody").gameObject;
                        GameObject LowerBody = Instance.transform.Find("Body/LowerBody").gameObject;
                        GameObject LowerArm = Instance.transform.Find("BackArm/LowerArm").gameObject;
                        GameObject UpperArm = Instance.transform.Find("BackArm/UpperArm").gameObject;
                        GameObject LowerArmFront = Instance.transform.Find("FrontArm/LowerArmFront").gameObject;
                        GameObject UpperArmFront = Instance.transform.Find("FrontArm/UpperArmFront").gameObject;
                        #endregion

                        UpperBody.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Metal");
                        UpperBody.GetOrAddComponent<AlwaysGoodBloodFlow>();
                        UpperBody.GetComponent<SkinMaterialHandler>().intensityMultiplier = 1f / 4f;
                        MiddleBody.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Metal");
                        MiddleBody.GetOrAddComponent<AlwaysGoodBloodFlow>();
                        MiddleBody.GetComponent<SkinMaterialHandler>().intensityMultiplier = 1f / 4f;
                        LowerBody.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Metal");
                        LowerBody.GetOrAddComponent<AlwaysGoodBloodFlow>();
                        LowerBody.GetComponent<SkinMaterialHandler>().intensityMultiplier = 1f / 4f;

                        Head.GetComponent<SpriteRenderer>().sortingLayerName = "Default";

                        Head.GetComponent<SkinMaterialHandler>().intensityMultiplier = 1f / 4f;
                        Head.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Metal");
                        Head.GetOrAddComponent<AlwaysGoodBloodFlow>();
                        DetectDeadLimbAndPlaySound DeathSound = Head.GetOrAddComponent<DetectDeadLimbAndPlaySound>();
                        DeathSound.limb = Head.GetComponent<LimbBehaviour>();
                        DeathSound.clip = new AudioClip[]
                        {
                            ModAPI.LoadSound("SFX/Combine Die/die1.wav"),
                            ModAPI.LoadSound("SFX/Combine Die/die2.wav"),
                            ModAPI.LoadSound("SFX/Combine Die/die3.wav"),
                        };

                        LowerBody.GetComponent<SpriteRenderer>().sortingLayerName = "Foreground";
                        LowerBody.GetComponent<SpriteRenderer>().sortingOrder = 2;
                        LowerArmFront.GetComponent<SpriteRenderer>().sortingOrder = 3;
                        UpperBody.GetComponent<SpriteRenderer>().sortingOrder = 2;

                        Head.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Guard/Head Skin 2.png"), ModAPI.LoadSprite("Sprites/Guard/Head Flesh.png"), ModAPI.LoadSprite("Sprites/Guard/Head Skeleton.png"), ModAPI.LoadSprite("Sprites/Guard/Head Damage.png"));
                        UpperBody.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Guard/Upper Body Skin.png"), ModAPI.LoadSprite("Sprites/Guard/Upper Body Flesh.png"), ModAPI.LoadSprite("Sprites/Guard/Upper Body Skeleton.png"), ModAPI.LoadSprite("Sprites/Guard/Upper Body Damage.png"));
                        MiddleBody.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Guard/Middle Body Skin.png"), ModAPI.LoadSprite("Sprites/Guard/Middle Body Flesh.png"), ModAPI.LoadSprite("Sprites/Guard/Middle Body Skeleton.png"), ModAPI.LoadSprite("Sprites/Guard/Middle Body Damage.png"));
                        LowerBody.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Guard/Lower Body Skin.png"), ModAPI.LoadSprite("Sprites/Guard/Lower Body Flesh.png"), ModAPI.LoadSprite("Sprites/Guard/Lower Body Skeleton.png"), ModAPI.LoadSprite("Sprites/Guard/Lower Body Damage.png"));
                    }
                }
            );
            #endregion
            #region Shotguneer
            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Shotguneer" + ModTag,
                    NameToOrderByOverride = "h",
                    DescriptionOverride = "I know these are named Shotgun Soldier, but Shotguneer sounds cooler. \nThey exclusively wield the shotgun. Shotgun Soldiers can be distinguished by their grey and red uniforms and battle armor. Their helmets are slightly darker than the average Combine Soldier, and have blood red/orange goggles.",
                    CategoryOverride = ModAPI.FindCategory("Half Life 2 Characters Mod"),
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Shotguneer.png", 5f),
                    AfterSpawn = (Instance) =>
                    {

                        var skin = ModAPI.LoadTexture("Sprites/Shotguneer/Skin.png");

                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin);
                        person.RandomisedSize = false;

                        var prop = ModAPI.FindPhysicalProperties("Metal");

                        foreach (var body in person.Limbs)
                        {
                            body.DiscomfortingHeatTemperature = 10000000000f;
                            body.ImpactDamageMultiplier = 0f;
                            body.ImpactPainMultiplier = 0f;
                            body.RegenerationSpeed = 6f;
                            body.Health = 175f;
                            body.InitialHealth = 175f;
                            body.BaseStrength = 7.5f;
                            body.BreakingThreshold = 8f;
                            body.HasBrain = false;
                            body.HasLungs = false;
                        }

                        if (Instance.transform.localScale.x > 0f)
                        {
                            Instance.transform.localScale = new Vector3(1.11f, 1.11f, 1f);
                        }
                        else
                        {
                            Instance.transform.localScale = new Vector3(-1.11f, 1.11f, 1f);
                        }

                        #region Limb List
                        GameObject Head = Instance.transform.Find("Head").gameObject;
                        GameObject UpperBody = Instance.transform.Find("Body/UpperBody").gameObject;
                        GameObject MiddleBody = Instance.transform.Find("Body/MiddleBody").gameObject;
                        GameObject LowerBody = Instance.transform.Find("Body/LowerBody").gameObject;
                        GameObject LowerArm = Instance.transform.Find("BackArm/LowerArm").gameObject;
                        GameObject UpperArm = Instance.transform.Find("BackArm/UpperArm").gameObject;
                        GameObject LowerArmFront = Instance.transform.Find("FrontArm/LowerArmFront").gameObject;
                        GameObject UpperArmFront = Instance.transform.Find("FrontArm/UpperArmFront").gameObject;
                        #endregion

                        UpperBody.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Metal");
                        UpperBody.GetOrAddComponent<AlwaysGoodBloodFlow>();
                        UpperBody.GetComponent<SkinMaterialHandler>().intensityMultiplier = 1f / 4f;
                        MiddleBody.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Metal");
                        MiddleBody.GetOrAddComponent<AlwaysGoodBloodFlow>();
                        MiddleBody.GetComponent<SkinMaterialHandler>().intensityMultiplier = 1f / 4f;
                        LowerBody.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Metal");
                        LowerBody.GetOrAddComponent<AlwaysGoodBloodFlow>();
                        LowerBody.GetComponent<SkinMaterialHandler>().intensityMultiplier = 1f / 4f;

                        Head.GetComponent<SpriteRenderer>().sortingLayerName = "Default";

                        Head.GetComponent<SkinMaterialHandler>().intensityMultiplier = 1f / 4f;
                        Head.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Metal");
                        Head.GetOrAddComponent<AlwaysGoodBloodFlow>();
                        DetectDeadLimbAndPlaySound DeathSound = Head.GetOrAddComponent<DetectDeadLimbAndPlaySound>();
                        DeathSound.limb = Head.GetComponent<LimbBehaviour>();
                        DeathSound.clip = new AudioClip[]
                        {
                            ModAPI.LoadSound("SFX/Combine Die/die1.wav"),
                            ModAPI.LoadSound("SFX/Combine Die/die2.wav"),
                            ModAPI.LoadSound("SFX/Combine Die/die3.wav"),
                        };

                        LowerBody.GetComponent<SpriteRenderer>().sortingLayerName = "Foreground";
                        LowerBody.GetComponent<SpriteRenderer>().sortingOrder = 2;
                        LowerArmFront.GetComponent<SpriteRenderer>().sortingOrder = 3;
                        UpperBody.GetComponent<SpriteRenderer>().sortingOrder = 2;

                        Head.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Shotguneer/Head Skin.png"), ModAPI.LoadSprite("Sprites/Shotguneer/Head Flesh.png"), ModAPI.LoadSprite("Sprites/Shotguneer/Head Skeleton.png"), ModAPI.LoadSprite("Sprites/Shotguneer/Head Damage.png"));
                        UpperBody.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Shotguneer/Upper Body Skin.png"), ModAPI.LoadSprite("Sprites/Shotguneer/Upper Body Flesh.png"), ModAPI.LoadSprite("Sprites/Shotguneer/Upper Body Skeleton.png"), ModAPI.LoadSprite("Sprites/Shotguneer/Upper Body Damage.png"));
                        MiddleBody.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Shotguneer/Middle Body Skin.png"), ModAPI.LoadSprite("Sprites/Shotguneer/Middle Body Flesh.png"), ModAPI.LoadSprite("Sprites/Shotguneer/Middle Body Skeleton.png"), ModAPI.LoadSprite("Sprites/Shotguneer/Middle Body Damage.png"));
                        LowerBody.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Shotguneer/Lower Body Skin.png"), ModAPI.LoadSprite("Sprites/Shotguneer/Lower Body Flesh.png"), ModAPI.LoadSprite("Sprites/Shotguneer/Lower Body Skeleton.png"), ModAPI.LoadSprite("Sprites/Shotguneer/Lower Body Damage.png"));
                    }
                }
            );
            #endregion
            #region Elite
            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Combine Elite" + ModTag,
                    NameToOrderByOverride = "h",
                    DescriptionOverride = "He's a specialized, higher-ranking Combine Soldier. Sporting a distinctive white uniform and helmet with a single red ocular lens, the Elite is the deadliest of the Combine Overwatch infantry.",
                    CategoryOverride = ModAPI.FindCategory("Half Life 2 Characters Mod"),
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Elite.png", 5f),
                    AfterSpawn = (Instance) =>
                    {

                        var skin = ModAPI.LoadTexture("Sprites/Elite/Skin.png");

                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin);
                        person.RandomisedSize = false;

                        var prop = ModAPI.FindPhysicalProperties("Metal");

                        foreach (var body in person.Limbs)
                        {
                            body.DiscomfortingHeatTemperature = 10000000000f;
                            body.ImpactDamageMultiplier = 0f;
                            body.ImpactPainMultiplier = 0f;
                            body.RegenerationSpeed = 10f;
                            body.Health = 200f;
                            body.InitialHealth = 200f;
                            body.BaseStrength = 10f;
                            body.BreakingThreshold = 8f;
                            body.HasBrain = false;
                            body.HasLungs = false;
                            body.gameObject.GetOrAddComponent<AlwaysGoodBloodFlow>();
                        }

                        if (Instance.transform.localScale.x > 0f)
                        {
                            Instance.transform.localScale = new Vector3(1.11f, 1.11f, 1f);
                        }
                        else
                        {
                            Instance.transform.localScale = new Vector3(-1.11f, 1.11f, 1f);
                        }

                        #region Limb List
                        GameObject Head = Instance.transform.Find("Head").gameObject;
                        GameObject UpperBody = Instance.transform.Find("Body/UpperBody").gameObject;
                        GameObject MiddleBody = Instance.transform.Find("Body/MiddleBody").gameObject;
                        GameObject LowerBody = Instance.transform.Find("Body/LowerBody").gameObject;
                        GameObject LowerArm = Instance.transform.Find("BackArm/LowerArm").gameObject;
                        GameObject UpperArm = Instance.transform.Find("BackArm/UpperArm").gameObject;
                        GameObject LowerArmFront = Instance.transform.Find("FrontArm/LowerArmFront").gameObject;
                        GameObject UpperArmFront = Instance.transform.Find("FrontArm/UpperArmFront").gameObject;
                        #endregion

                        UpperBody.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Metal");
                        UpperBody.GetComponent<SkinMaterialHandler>().intensityMultiplier = 1f / 4f;
                        MiddleBody.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Metal");
                        MiddleBody.GetComponent<SkinMaterialHandler>().intensityMultiplier = 1f / 4f;
                        LowerBody.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Metal");
                        LowerBody.GetComponent<SkinMaterialHandler>().intensityMultiplier = 1f / 4f;

                        Head.GetComponent<SpriteRenderer>().sortingLayerName = "Default";

                        Head.GetComponent<SkinMaterialHandler>().intensityMultiplier = 1f / 4f;
                        Head.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Metal");
                        DetectDeadLimbAndPlaySound DeathSound = Head.GetOrAddComponent<DetectDeadLimbAndPlaySound>();
                        DeathSound.limb = Head.GetComponent<LimbBehaviour>();
                        DeathSound.clip = new AudioClip[]
                        {
                            ModAPI.LoadSound("SFX/Combine Die/die1.wav"),
                            ModAPI.LoadSound("SFX/Combine Die/die2.wav"),
                            ModAPI.LoadSound("SFX/Combine Die/die3.wav"),
                        };

                        UpperBody.GetComponent<SpriteRenderer>().sortingOrder = 2;

                        Head.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Elite/Head Skin.png"), ModAPI.LoadSprite("Sprites/Elite/Head Flesh.png"), ModAPI.LoadSprite("Sprites/Elite/Head Skeleton.png"), ModAPI.LoadSprite("Sprites/Elite/Head Damage.png"));
                        UpperBody.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Elite/Upper Body Skin.png"), ModAPI.LoadSprite("Sprites/Elite/Upper Body Flesh.png"), ModAPI.LoadSprite("Sprites/Elite/Upper Body Skeleton.png"), ModAPI.LoadSprite("Sprites/Elite/Upper Body Damage.png"));
                        MiddleBody.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Elite/Middle Body Skin.png"), ModAPI.LoadSprite("Sprites/Elite/Middle Body Flesh.png"), ModAPI.LoadSprite("Sprites/Elite/Middle Body Skeleton.png"), ModAPI.LoadSprite("Sprites/Elite/Middle Body Damage.png"));
                        LowerBody.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Elite/Lower Body Skin.png"), ModAPI.LoadSprite("Sprites/Elite/Lower Body Flesh.png"), ModAPI.LoadSprite("Sprites/Elite/Lower Body Skeleton.png"), ModAPI.LoadSprite("Sprites/Elite/Lower Body Damage.png"));
                    }
                }
            );
            #endregion
            #region Zombine
            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Zombine" + ModTag,
                    NameToOrderByOverride = "h",
                    DescriptionOverride = "The Zombine, a portmanteau of Combine and Zombie, is the result of a Standard Headcrab attaching to the head of an Overwatch Soldier.",
                    CategoryOverride = ModAPI.FindCategory("Half Life 2 Characters Mod"),
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Zombine.png", 5f),
                    AfterSpawn = (Instance) =>
                    {

                        var skin = ModAPI.LoadTexture("Sprites/Zombine/Skin.png");

                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin);
                        person.RandomisedSize = false;

                        var prop = ModAPI.FindPhysicalProperties("Metal");

                        foreach (var body in person.Limbs)
                        {
                            body.DiscomfortingHeatTemperature = 10000000000f;
                            body.ImpactDamageMultiplier = 0f;
                            body.ImpactPainMultiplier = 0f;
                            body.RegenerationSpeed = 8f;
                            body.Health = 145f;
                            body.InitialHealth = 145f;
                            body.BaseStrength = 7.25f;
                            body.BreakingThreshold = 7.5f;
                            body.HasBrain = false;
                            body.HasLungs = false;
                        }

                        if (Instance.transform.localScale.x > 0f)
                        {
                            Instance.transform.localScale = new Vector3(1.11f, 1.11f, 1f);
                        }
                        else
                        {
                            Instance.transform.localScale = new Vector3(-1.11f, 1.11f, 1f);
                        }

                        #region Limb List
                        GameObject Head = Instance.transform.Find("Head").gameObject;
                        GameObject UpperBody = Instance.transform.Find("Body/UpperBody").gameObject;
                        GameObject MiddleBody = Instance.transform.Find("Body/MiddleBody").gameObject;
                        GameObject LowerBody = Instance.transform.Find("Body/LowerBody").gameObject;
                        GameObject LowerArm = Instance.transform.Find("BackArm/LowerArm").gameObject;
                        GameObject UpperArm = Instance.transform.Find("BackArm/UpperArm").gameObject;
                        GameObject LowerArmFront = Instance.transform.Find("FrontArm/LowerArmFront").gameObject;
                        GameObject UpperArmFront = Instance.transform.Find("FrontArm/UpperArmFront").gameObject;
                        #endregion

                        UpperBody.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Metal");
                        MiddleBody.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Metal");
                        LowerBody.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Metal");

                        Head.GetComponent<SpriteRenderer>().sortingLayerName = "Default";
                        DetectDeadLimbAndPlaySound DeathSound = Head.GetOrAddComponent<DetectDeadLimbAndPlaySound>();
                        DeathSound.limb = Head.GetComponent<LimbBehaviour>();
                        DeathSound.clip = new AudioClip[]
                        {
                            ModAPI.LoadSound("SFX/Combine Die/die1.wav"),
                            ModAPI.LoadSound("SFX/Combine Die/die2.wav"),
                            ModAPI.LoadSound("SFX/Combine Die/die3.wav"),
                        };

                        LowerBody.GetComponent<SpriteRenderer>().sortingLayerName = "Foreground";
                        LowerBody.GetComponent<SpriteRenderer>().sortingOrder = 2;
                        LowerArmFront.GetComponent<SpriteRenderer>().sortingOrder = 3;
                        UpperBody.GetComponent<SpriteRenderer>().sortingOrder = 2;

                        UpperBody.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Zombine/Upper Body Skin.png"), ModAPI.LoadSprite("Sprites/Zombine/Upper Body Flesh.png"), ModAPI.LoadSprite("Sprites/Zombine/Upper Body Skeleton.png"), ModAPI.LoadSprite("Sprites/Zombine/Upper Body Damage.png"));
                        MiddleBody.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Zombine/Middle Body Skin.png"), ModAPI.LoadSprite("Sprites/Zombine/Middle Body Flesh.png"), ModAPI.LoadSprite("Sprites/Zombine/Middle Body Skeleton.png"), ModAPI.LoadSprite("Sprites/Zombine/Middle Body Damage.png"));
                        LowerBody.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Zombine/Lower Body Skin.png"), ModAPI.LoadSprite("Sprites/Zombine/Lower Body Flesh.png"), ModAPI.LoadSprite("Sprites/Zombine/Lower Body Skeleton.png"), ModAPI.LoadSprite("Sprites/Zombine/Lower Body Damage.png"));
                    }
                }
            );
            #endregion
            #region Zombie
            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Zombie" + ModTag,
                    NameToOrderByOverride = "h",
                    DescriptionOverride = "A Zombie is a common enemy featured in the Half-Life series. It is the result of a Headcrab attaching to the head of a human and taking control over its victim's body.",
                    CategoryOverride = ModAPI.FindCategory("Half Life 2 Characters Mod"),
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Zombie.png", 5f),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Sprites/Headcrab Zombie/Skin.png");
                        var flesh = ModAPI.LoadTexture("Sprites/Headcrab Zombie/Flesh.png");
                        var skeleton = ModAPI.LoadTexture("Sprites/Headcrab Zombie/Skeleton.png");

                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, flesh, skeleton);

                        #region Limb List
                        GameObject Head = Instance.transform.Find("Head").gameObject;
                        GameObject UpperBody = Instance.transform.Find("Body/UpperBody").gameObject;
                        GameObject MiddleBody = Instance.transform.Find("Body/MiddleBody").gameObject;
                        GameObject LowerBody = Instance.transform.Find("Body/LowerBody").gameObject;
                        GameObject LowerArm = Instance.transform.Find("BackArm/LowerArm").gameObject;
                        GameObject UpperArm = Instance.transform.Find("BackArm/UpperArm").gameObject;
                        GameObject LowerArmFront = Instance.transform.Find("FrontArm/LowerArmFront").gameObject;
                        GameObject UpperArmFront = Instance.transform.Find("FrontArm/UpperArmFront").gameObject;
                        #endregion

                        UpperBody.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Headcrab Zombie/Upper Body Skin.png"), ModAPI.LoadSprite("Sprites/Headcrab Zombie/Upper Body Flesh.png"), ModAPI.LoadSprite("Sprites/Headcrab Zombie/Upper Body Skeleton.png"), ModAPI.LoadSprite("Sprites/Headcrab Zombie/Upper Body Damage.png"));
                        MiddleBody.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Headcrab Zombie/Middle Body Skin.png"), ModAPI.LoadSprite("Sprites/Headcrab Zombie/Middle Body Flesh.png"), ModAPI.LoadSprite("Sprites/Headcrab Zombie/Middle Body Skeleton.png"), ModAPI.LoadSprite("Sprites/Headcrab Zombie/Middle Body Damage.png"));
                        LowerBody.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Headcrab Zombie/Lower Body Skin.png"), ModAPI.LoadSprite("Sprites/Headcrab Zombie/Lower Body Flesh.png"), ModAPI.LoadSprite("Sprites/Headcrab Zombie/Lower Body Skeleton.png"), ModAPI.LoadSprite("Sprites/Headcrab Zombie/Lower Body Damage.png"));
                        LowerArm.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Headcrab Zombie/Lower Arm Skin.png"), ModAPI.LoadSprite("Sprites/Headcrab Zombie/Lower Arm Flesh.png"), ModAPI.LoadSprite("Sprites/Headcrab Zombie/Lower Arm Skeleton.png"), ModAPI.LoadSprite("Sprites/Headcrab Zombie/Lower Arm Damage.png"));
                        LowerArmFront.GetComponent<LimbBehaviour>().SetLimbSprite(ModAPI.LoadSprite("Sprites/Headcrab Zombie/Lower Arm Skin.png"), ModAPI.LoadSprite("Sprites/Headcrab Zombie/Lower Arm Flesh.png"), ModAPI.LoadSprite("Sprites/Headcrab Zombie/Lower Arm Skeleton.png"), ModAPI.LoadSprite("Sprites/Headcrab Zombie/Lower Arm Damage.png"));
                    }
                }
            );
            #endregion
            #region Headcrab
            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Rod"),
                    NameOverride = "Headcrab" + ModTag,
                    NameToOrderByOverride = "h",
                    DescriptionOverride = "Headcrabs are omnivorous, parasitic alien organisms from Xen.",
                    CategoryOverride = ModAPI.FindCategory("Half Life 2 Characters Mod"),
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Headcrab.png", 5f),
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Sprites/Headcrab/Body.png");
                        Instance.GetComponent<SpriteRenderer>().sortingLayerName = "Foreground";
                        Instance.GetComponent<SpriteRenderer>().sortingOrder = 0;
                        Instance.FixColliders();
                        PhysicalBehaviour physicalBehaviour = Instance.GetComponent<PhysicalBehaviour>();
                        physicalBehaviour.Properties = ModAPI.FindPhysicalProperties("Human");
                        GameObject BackLeg = ModAPI.CreatePhysicalObject("BackLeg", ModAPI.LoadSprite("Sprites/Headcrab/Back Leg.png"));
                        BackLeg.GetComponent<SpriteRenderer>().sortingLayerName = "Foreground";
                        BackLeg.GetComponent<SpriteRenderer>().sortingOrder = 1;
                        BackLeg.transform.SetParent(Instance.transform);
                        BackLeg.transform.localRotation = Quaternion.identity;
                        BackLeg.transform.localScale = Vector3.one;
                        BackLeg.transform.localPosition = new Vector3(-0.243f, -0.157f);
                        BackLeg.GetComponent<PhysicalBehaviour>().InitialMass = 0.05f;
                        BackLeg.GetComponent<PhysicalBehaviour>().TrueInitialMass = 0.05f;
                        BackLeg.GetComponent<PhysicalBehaviour>().rigidbody.mass = 0.05f;
                        BackLeg.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Human");
                        FixedJoint2D BackLegJoint = BackLeg.AddComponent<FixedJoint2D>();
                        BackLegJoint.anchor = new Vector2(0.03f, 0.124f);
                        BackLegJoint.connectedBody = Instance.GetComponent<Rigidbody2D>();
                        BackLegJoint.frequency = 6;
                        BackLegJoint.dampingRatio = 1f;
                        GameObject FrontLeg = ModAPI.CreatePhysicalObject("FrontLeg", ModAPI.LoadSprite("Sprites/Headcrab/Front Leg.png"));
                        FrontLeg.GetComponent<SpriteRenderer>().sortingLayerName = "Foreground";
                        FrontLeg.GetComponent<SpriteRenderer>().sortingOrder = 1;
                        FrontLeg.transform.SetParent(Instance.transform);
                        FrontLeg.transform.localRotation = Quaternion.identity;
                        FrontLeg.transform.localScale = Vector3.one;
                        FrontLeg.transform.localPosition = new Vector3(0.3849f, -0.1423f);
                        FrontLeg.GetComponent<PhysicalBehaviour>().InitialMass = 0.05f;
                        FrontLeg.GetComponent<PhysicalBehaviour>().TrueInitialMass = 0.05f;
                        FrontLeg.GetComponent<PhysicalBehaviour>().rigidbody.mass = 0.05f;
                        FrontLeg.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Human");
                        FixedJoint2D FrontLegJoint = FrontLeg.AddComponent<FixedJoint2D>();
                        FrontLegJoint.anchor = new Vector2(-0.241f, 0.042f);
                        FrontLegJoint.connectedBody = Instance.GetComponent<Rigidbody2D>();
                        FrontLegJoint.frequency = 6;
                        FrontLegJoint.dampingRatio = 1f;

                        NoCollide noCollide = Instance.AddComponent<NoCollide>();
                        noCollide.NoCollideSetA = Instance.GetComponents<Collider2D>();
                        noCollide.NoCollideSetB = Instance.GetComponentsInChildren<Collider2D>();

                        Instance.GetOrAddComponent<Headcrab>();
                    }
                }
            );
            #endregion
            #endregion
        }
    }
}
public class Headcrab : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        var limb = collision.transform.GetComponent<LimbBehaviour>();
        if (limb)
            if (limb.RoughClassification == LimbBehaviour.BodyPart.Head && !limb.IsAndroid)
            {
                gameObject.layer = 10;
                transform.Find("FrontLeg").gameObject.layer = 10;
                transform.Find("FrontLeg").GetComponent<FixedJoint2D>().frequency = 2;
                transform.Find("BackLeg").gameObject.layer = 10;
                transform.Find("BackLeg").GetComponent<FixedJoint2D>().frequency = 2;
                transform.parent = collision.transform;
                transform.localPosition = Vector3.zero;
                transform.localRotation = Quaternion.identity;
                transform.localScale = Vector3.one;
                transform.parent = collision.transform.root;
                gameObject.AddComponent<FixedJoint2D>().connectedBody = collision.rigidbody;
            }
    }
}
public class DetectDeadLimbAndPlaySound : MonoBehaviour
{
    public LimbBehaviour limb;
    public bool dead;
    public AudioClip[] clip;

    void Update()
    {
        if (limb.Health <= 0 && !dead)
        {
            dead = true;
            PlaySound();
        }
    }

    void PlaySound()
    {
        AudioSource audioSource = gameObject.AddComponent<AudioSource>();
        gameObject.AddComponent<AudioSourceTimeScaleBehaviour>();
        audioSource.dopplerLevel = 0f;
        audioSource.playOnAwake = false;
        audioSource.rolloffMode = AudioRolloffMode.Linear;
        audioSource.minDistance = 1f;
        audioSource.maxDistance = 75f;
        audioSource.spatialBlend = 1f;
        audioSource.clip = clip.PickRandom();
        audioSource.Play();
    }
}
public class FirstSpawn : MonoBehaviour
{

}