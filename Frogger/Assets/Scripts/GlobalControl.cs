using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalControl : MonoBehaviour
{
    public static GlobalControl Instance;

    public float NameInput;
    public float Lives;
    public float GameSpeed;

    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        NameInput = GlobalControl.Instance.NameInput;
        Lives = GlobalControl.Instance.Lives;
        GameSpeed = GlobalControl.Instance.GameSpeed;
    }
}
