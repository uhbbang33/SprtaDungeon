using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    [SerializeField] EquipPanelUI _equipPanelUI;

    [SerializeField] private GameObject _buttonPanel;
    [SerializeField] private GameObject _equipPanel;

    [SerializeField] private List<GameObject> _inventoryObject;
    [SerializeField] private List<Image> _inventoryButtonsImage;

    private List<Button> _buttons;

    Player player;


    private void Start()
    { 
        player = GameManager.Instance.player;
        InitializeInventory();
        
        _buttons = new List<Button>();
        for (int i = 0; i < _inventoryObject.Count; ++i)
        {
            _buttons.Add(_inventoryObject[i].GetComponent<Button>());
            _buttons[i].onClick.AddListener(() => ApplyGearInfoToEquipPanel(i));
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
    }


    #region Button

    private void ApplyGearInfoToEquipPanel(int buttonNum)
    {
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
