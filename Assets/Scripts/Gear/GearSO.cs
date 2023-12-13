using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum StatType { ATTACK, DEFENSE, HP, CRITICAL }

[CreateAssetMenu(fileName = "DefaultGearData", menuName = "GearSO/Default", order = 0)]
public class GearSO : ScriptableObject
{
    public string GearName;
    public StatType Type;
    public int Stat;
    public string Description;
    public int Price;
    public Sprite GearSprite;
    public bool IsEquip;
}
