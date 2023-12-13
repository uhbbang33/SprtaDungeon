using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EquipPanelUI : MonoBehaviour
{
    // GameObject�� �ٲ�� �ϳ�?
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

        // enum�� tostring���� �ٲٸ� ���ұ�?
        _gearTypeText.text = gearSO.Type.ToString();
        _gearStat.text = gearSO.Stat.ToString();

    }


    #region Button

    public void EquipGear()
    {

    }

    #endregion
}
