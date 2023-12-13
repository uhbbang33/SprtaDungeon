using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Player : MonoBehaviour
{
    [SerializeField] private PlayerDataSO _playerDataSO;

    public string PlayerTitle { get; private set; }
    public string PlayerId {  get; private set; }
    public int Level { get; private set; }
    public int Exp {  get; private set; }
    public int MaxExp { get; private set; }
    public string Description {  get; private set; }
    public int Gold { get; private set; }

    public int AttackPower {  get; private set; }
    public int DefensePower {  get; private set; }
    public int MaxHp {  get; private set; }
    public int CriticalPower {  get; private set; }
    public List<GearSO> Gears { get; private set; }

    private void Awake()
    {
        InitializePlayer();
    }
    private void InitializePlayer()
    {
        PlayerTitle = _playerDataSO.PlayerTitle;
        PlayerId = _playerDataSO.PlayerId;
        Level = _playerDataSO.Level;
        Exp = _playerDataSO.Exp;
        MaxExp = _playerDataSO.MaxExp;
        Description = _playerDataSO.Description;
        Gold = _playerDataSO.Gold;

        AttackPower = _playerDataSO.AttackPower;
        DefensePower = _playerDataSO.DefensePower;
        MaxHp = _playerDataSO.MaxHp;
        CriticalPower = _playerDataSO.CriticalPower;
        Gears = _playerDataSO.Gears;
    }

    public void UpdateStat(StatType type, int statNum)
    {
        switch (type)
        {
            case StatType.ATTACK:
                AttackPower += statNum;
                break;
            case StatType.DEFENSE:
                DefensePower += statNum;
                break;
            case StatType.HP:
                MaxHp += statNum;
                break;
            case StatType.CRITICAL:
                CriticalPower += statNum;
                break;
        }
    }
}
