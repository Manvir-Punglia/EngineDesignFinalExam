using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LectureStuff
{
    public class Player : MonoBehaviour
    {
        public delegate void OnHealthChangedDelegate(float newHealth);

        public event OnHealthChangedDelegate OnHealthChanged;
        private float _health;
        private bool _isDirty = true;

        public float Health
        {
            get { return _health; }
            set
            {
                if (_health != value)
                {
                    _health = value;
                    SetDirty();
                }
            }
        }

        private void SetDirty()
        {
            _isDirty = true;
            OnHealthChanged?.Invoke(_health);
        }

        private void Update()
        {
            if (_isDirty)
            {
// Simulate updating some internal state
                Debug.Log("Updating internal state with health: " + _health);
                _isDirty = false;
            }
        }
    }
}