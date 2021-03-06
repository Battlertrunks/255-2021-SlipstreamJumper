using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Jelsomeno
{

    public class HealthBar : MonoBehaviour
    {
        /// <summary>
        /// referenc to the health system script
        /// </summary>
        public Health playerHealth;
        /// <summary>
        /// reference to the slider in the canvas
        /// </summary>
        public Image fillImage;
        /// <summary>
        /// reference to the sldier 
        /// </summary>
        private Slider slider;

        void Start()
        {
            slider = GetComponent<Slider>(); // get the slider componenet on the canvas and that the script is connected to 
        }

        // Update is called once per frame
        void Update()
        {
            if (slider.value <= slider.minValue)
            {
                fillImage.enabled = false;

            }
            if (slider.value > slider.minValue && !fillImage.enabled)
            {
                fillImage.enabled = true;
            }

            float fillValue = playerHealth.currentHealth / playerHealth.healthMax;
            if(fillValue <= slider.maxValue / 3)
            {
                fillImage.color = Color.red; // danger health bar color, basically changes the color to red wants it get its down to a certain point 
            }
            else if (fillValue > slider.maxValue / 3)
            {
                fillImage.color = Color.green; // normal health bar color
            }
            slider.value = fillValue;
        }
    }

}
