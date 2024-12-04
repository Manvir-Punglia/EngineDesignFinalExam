using System.Collections;
using System.Collections.Generic;
using LectureStuff;
using UnityEngine;
using UnityEngine.UI;

namespace LectureStudio
{
    public class PlayerUI : MonoBehaviour
    {
        public Player player;
        public Text healthText;
        private void OnEnable()
        {
            if (player != null)
            {
                player.OnHealthChanged += UpdateHealthUI;
            }
        }
        private void OnDisable()
        {
            if (player != null)
            {
                player.OnHealthChanged -= UpdateHealthUI;
            }
        }
        private void UpdateHealthUI(float newHealth)
        {
            if (healthText != null)
            {
                healthText.text = "Health: " + newHealth;
            }
        }
    }
}