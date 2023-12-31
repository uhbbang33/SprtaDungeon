using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    [SerializeField] private EquipPanelUI _equipPanelUI;

    [SerializeField] private GameObject _buttonPanel;
    [SerializeField] private GameObject _equipPanel;

    [SerializeField] private List<GameObject> _inventoryObject;
    [SerializeField] private List<Image> _inventoryButtonsImage;
    [SerializeField] private List<GameObject> _inventoryEquipment;

    private List<Button> _buttons;

    Player player;


    private void Start()
    { 
        player = GameManager.Instance.player;
        InitializeInventory();

        _buttons = new List<Button>();
        for (int i = 0; i < player.Gears.Count; ++i)
        {
            _buttons.Add(_inventoryObject[i].GetComponent<Button>());

            // TIL
            int index = i;
            _buttons[i].onClick.AddListener(() => ApplyGearInfoToEquipPanel(_buttons[index]));
        }
    }

    private void InitializeInventory()
    {
        for (int i = 0; i < player.Gears.Count; ++i)
        {
            // Sprite Setting
            _inventoryButtonsImage[i].GetComponent<Image>().sprite
                = player.Gears[i].GearSprite;

            Color originColor = _inventoryButtonsImage[i].color;
            _inventoryButtonsImage[i].color = new Color(originColor.r, originColor.g, originColor.b, 1f);
        }

        UpdateEquipImage();
    }

    public void UpdateEquipImage()
    {
        // temp
        for (int i = 0; i<player.Gears.Count; ++i)
        {
            if (player.Gears[i].IsEquip)
                _inventoryEquipment[i].SetActive(true);
            else
                _inventoryEquipment[i].SetActive(false);
        }
    }

    #region Button

    private void ApplyGearInfoToEquipPanel(Button button)
    {
        int buttonNum = _buttons.IndexOf(button);

        if (player.Gears.Count < buttonNum)
        {
            // temp
            GearSO so = new GearSO();
            _equipPanelUI.UpdateEquipPanel(so);
        }
        else
            _equipPanelUI.UpdateEquipPanel(player.Gears[buttonNum]);
    }

    public void ShowEquipPanel()
    {
        _equipPanel.SetActive(true);
    }

    public void BackToMain()
    {
        _buttonPanel.SetActive(true);
        _equipPanel.SetActive(false);
        gameObject.SetActive(false);
    }

    #endregion
}
