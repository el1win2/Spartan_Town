using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class RealTime : MonoBehaviour
{
    public Text timeTxt;
    public string time;
    void Update()
    {
        time = DateTime.Now.ToString("HH:mm");
        timeTxt.text = time;
    }
}
