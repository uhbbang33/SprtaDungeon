using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EquipPanelUI : MonoBehaviour
{
    [SerializeField] private Image _gearImage;
    [SerializeField] private TextMeshProUGUI _gearName;
    [SerializeField] private TextMeshProUGUI _gearDescription;
    [SerializeField] private Image _gearTypeImage;
    [SerializeField] private TextMeshProUGUI _gearTypeText;
    [SerializeField] private TextMeshProUGUI _gearStat;

    [SerializeField] private List<Sprite> _gearTypeSpriteList;

    GearSO _gearSO;
    Player _player;

    private void Start()
    {
        gameObject.SetActive(false);
        _gearSO = new GearSO();
        _player = GameManager.Instance.player;
    }

    public void UpdateEquipPanel(GearSO gearSO)
    {
        _gearImage.sprite = gearSO.GearSprite;
        _gearName.text = gearSO.GearName;
        _gearDescription.text = gearSO.Description;

        int gearTypeIndex = (int)gearSO.Type;
        _gearTypeImage.sprite = _gearTypeSpriteList[gearTypeIndex];

        _gearTypeText.text = gearSO.Type.ToString();
        _gearStat.text = gearSO.Stat.ToString();
        _gearSO = gearSO;
    }


    #region Button

    public void EquipGear()
    {
        _player.UpdateStat(_gearSO.Type, _gearSO.Stat);
    }
    
    public void CancelEquipPanel()
    {
        gameObject.SetActive(false);
    }
    
    #endregion
}
