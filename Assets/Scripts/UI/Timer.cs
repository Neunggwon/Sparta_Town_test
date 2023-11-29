using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour
{
    [SerializeField] 
    Text timer;

    void Update()
    {
        timer.text = DateTime.Now.ToString("HH : mm");
    }
}
