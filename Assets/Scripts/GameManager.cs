using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    [SerializeField] public Player player;

    public static GameManager Instance { get { return _instance; } }

    private void Awake()
    {
        _instance = this;
    }
}
