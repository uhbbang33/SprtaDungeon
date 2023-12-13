using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainUI : MonoBehaviour
{
    // Text
    [SerializeField] private TextMeshProUGUI _playerTitleText;
    [SerializeField] private TextMeshProUGUI _playerIdText;
    [SerializeField] private TextMeshProUGUI _playerLevelText;
    [SerializeField] private TextMeshProUGUI _playerExpText;
    [SerializeField] private TextMeshProUGUI _playerDescriptionText;
    [SerializeField] private TextMeshProUGUI _playerGoldText;

    // Panel
    [SerializeField] private GameObject _buttonPanel;
    [SerializeField] private GameObject _statusPanel;
    [SerializeField] private GameObject _inventoryPanel;

    private Player player;


    void Start()
    {
        player = GameManager.Instance.player;
        InitializeUI();
    }

    private void InitializeUI()
    {
        _playerTitleText.text = player.PlayerTitle;
        _playerIdText.text = player.PlayerId;
        _playerLevelText.text = "Lv " + player.Level;
        _playerExpText.text = player.Exp + " / " + player.MaxExp;
        _playerDescriptionText.text = player.Description;
        _playerGoldText.text = player.Gold.ToString();

        _buttonPanel.SetActive(true);
        _statusPanel.SetActive(false);
        _inventoryPanel.SetActive(false);
    }

    #region Button

    public void ShowStatusPanel()
    {
        _buttonPanel.SetActive(false);
        _statusPanel.SetActive(true);
    }

    public void ShowInventoryPanel()
    {
        _buttonPanel.SetActive(false);
        _inventoryPanel.SetActive(true);
    }

    #endregion
}
