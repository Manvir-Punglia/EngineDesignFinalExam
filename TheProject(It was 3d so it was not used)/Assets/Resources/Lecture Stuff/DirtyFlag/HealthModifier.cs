using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LectureStuff
{
    public class HealthModifier : MonoBehaviour
    {
        public Player player;

        private void Start()
        {
            if (player != null)
            {
                InvokeRepeating("ChangeHealth", 1.0f, 2.0f);
            }
        }

        private void ChangeHealth()
        {
            if (player != null)
            {
                player.Health = Random.Range(0, 100);
            }
        }
    }
}