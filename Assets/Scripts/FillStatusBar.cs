using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillStatusBar : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public Image fillImage;
    private Slider slider;
    // Start is called before the first frame update
    void Awake()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        DisableFillImageOnZeroHealth();
        float fillValue = playerHealth.currentHealth / playerHealth.maxHealth;
        slider.value = fillValue;
    }

    // Disables the fillIamge for Visual improvements.
    void DisableFillImageOnZeroHealth()
    {
        if (slider.value <= slider.minValue) fillImage.enabled = false; // remove if 0 or less
        if (slider.value > slider.minValue && !fillImage.enabled) fillImage.enabled = true; // enable if not enabled and hp is over 0
    }
}
