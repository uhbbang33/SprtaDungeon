using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StatusPanelUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _playerAttackPowerText;
    [SerializeField] private TextMeshProUGUI _playerDefensePowerText;
    [SerializeField] private TextMeshProUGUI _playerMaxHpText;
    [SerializeField] private TextMeshProUGUI _playerCriticalPowerText;

    [SerializeField] private GameObject _buttonPanelGameObject;

    Player player;

    void Start()
    {
        player = GameManager.Instance.player;
        InitializeUI();
    }

    public void InitializeUI()
    {
        _playerAttackPowerText.text = player.AttackPower.ToString();
        _playerDefensePowerText.text = player.DefensePower.ToString();
        _playerMaxHpText.text = player.MaxHp.ToString();
        _playerCriticalPowerText.text = player.CriticalPower.ToString();
    }

    #region Button
    public void BackToMain()
    {
        _buttonPanelGameObject.SetActive(true);
        gameObject.SetActive(false);
    }
    #endregion
}
