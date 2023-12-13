using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Gear : MonoBehaviour
{
    [SerializeField] private GearSO _gearSO;

    public string GearName { get; private set; }
    public StatType Type { get; private set; }
    public int Stat { get; private set; }
    public string Description { get; private set; }
    public int Price { get; private set; }

    public Sprite GearSprite { get; private set; }

    void Awake()
    {
        InitializeGear();
    }

    private void InitializeGear()
    {
        GearName = _gearSO.GearName;
        Type = _gearSO.Type;
        Stat = _gearSO.Stat;
        Description = _gearSO.Description;
        Price = _gearSO.Price;

        GearSprite = _gearSO.GearSprite;
    }
}
