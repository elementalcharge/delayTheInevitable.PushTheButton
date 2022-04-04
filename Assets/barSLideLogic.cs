using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class barSLideLogic : MonoBehaviour
{
    public Slider slider;
    // Start is called before the first frame update
    public void setMaxHealth(float newMax)
    {
        slider.maxValue = newMax;
    }

    public void UpdateBar(float currentValue)
    {
        slider.value = currentValue;
    }
}
