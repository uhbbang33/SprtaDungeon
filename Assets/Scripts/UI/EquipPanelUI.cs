using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EquipPanelUI : MonoBehaviour
{
    // GameObject로 바꿔야 하나?
    [SerializeField] private Image _gearImage;
    [SerializeField] private TextMeshProUGUI _gearName;
    [SerializeField] private TextMeshProUGUI _gearDescription;
    [SerializeField] private Image _gearTypeImage;
    [SerializeField] private TextMeshProUGUI _gearTypeText;
    [SerializeField] private TextMeshProUGUI _gearStat;

    [SerializeField] private List<Sprite> _gearTypeSpriteList;


    private void Start()
    {
        gameObject.SetActive(false);
    }

    public void UpdateEquipPanel(GearSO gearSO)
    {
        _gearImage.sprite = gearSO.GearSprite;
        _gearName.text = gearSO.GearName;
        _gearDescription.text = gearSO.Description;

        int gearTypeIndex = (int)gearSO.Type;
        _gearTypeImage.sprite = _gearTypeSpriteList[gearTypeIndex];

        // enum을 tostring으로 바꾸면 변할까?
        _gearTypeText.text = gearSO.Type.ToString();
        _gearStat.text = gearSO.Stat.ToString();

    }


    #region Button

    public void EquipGear()
    {

    }

    #endregion
}
