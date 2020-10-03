using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    public Text levelText;
    public static int speedLevel;

    public void SliderUpdate(float value)
    {
        levelText.text =""+ Mathf.RoundToInt(value);
        speedLevel = Mathf.RoundToInt(value);
    }
}
