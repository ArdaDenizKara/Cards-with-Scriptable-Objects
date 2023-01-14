using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    
    public  string cardName;
    public int healthValue;
    public int damageValue;
    public int energyCost;
    public Sprite character;
}
