using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGameTime : MonoBehaviour
{
    [Range(0.1f, 10)]

    public float modifiedScale;


    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = modifiedScale;
    }
}
