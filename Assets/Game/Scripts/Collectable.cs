using UnityEngine;
using System.Collections;

/*
 * Describe a collectable object.  
 * 
 * 
 * 
 * 
 */

enum MagicGrade
{
    Diamond,
    Pearl,
    RedCoral,
    Hessonite,
    BlueSapphire,
    CatsEye,
    YellowSafire,
    Emerald,
    Ruby,
}

enum ItemTypeCategory
{
    Plant,
    Gem,
    Mineral,
    Metal,
    Fungus,
    Element,
    Biolological,
}

// Note: Bonuses can be additive or subtractive
enum ItemBenefitCategory
{
    HealthBonus,
    MagicBonus,
    SpeedBonus,
    StealthBonus,
    HealingBonus,
    MeleeAttackBonus,
    FlightBonus,
    MagicAttackBonus,
    ItemBonus,
}

enum BonusDuration
{
    Expires,
    Instant,
}

class Bonus
{
    public string _description;
    public string _short_description;
    public ItemBenefitCategory _benefit;
    public int _value;
    public BonusDuration _duration;

    public Bonus()
    {
        UberDebug.LogChannel("Collectable", "Bonus constructor");
    }
}

class CollectableValue
{

}

class Collectables : Bonus
{
    public MagicGrade _grade;
    public int _magic_level;
    public BonusDuration _duration;
    //public ArrayList arrayList;

    public Collectables() : base()
    {
        UberDebug.LogChannel("Collectable", "Collectables");
    }
}

class Collectable : MonoBehaviour
{
    public Collectables collectables = null;

    private void Start()
    {
        collectables = new Collectables();
        Debug.Assert(collectables != null);
        collectables._grade = MagicGrade.Diamond;
        collectables._duration = BonusDuration.Instant;

        UberDebug.LogChannel("Collectable", "Launch");
    }

    private void Update()
    {
        
    }
}