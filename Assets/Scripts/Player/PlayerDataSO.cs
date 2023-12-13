using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "PlayerSO", order = 1)]
public class PlayerDataSO : ScriptableObject
{
    public string PlayerTitle;
    public string PlayerId;
    public int Level;
    public int Exp;
    public int MaxExp;
    public string Description;
    public int Gold;

    [Header("Fight Stat")]
    public int AttackPower;
    public int DefensePower;
    public int MaxHp;
    public int CriticalPower;

    [Header("Gear")]
    public List<GearSO> Gears;
}
