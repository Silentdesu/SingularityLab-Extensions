﻿using System.Collections;
using UnityEngine;

namespace SingularityLab.Scripts.Utils
{
    public abstract class BaseUIPanel : MonoBehaviour
    {
        protected BaseCanvasController CanvasController;
        
        protected virtual void Awake()
        {
            CanvasController = GetComponentInParent<BaseCanvasController>();
        }

        public virtual void ShowDelayed(float delay = 0f)
        {
            delay = Mathf.Max(0f, delay);

            if (delay > 0f)
            {
                MainThreadRunner.Instance.StartCoroutine(ShowDelayedRoutine(delay));
            }
            else
            {
                ShowInstant();
            }
        }

        private IEnumerator ShowDelayedRoutine(float delay = 0f)
        {
            yield return new WaitForSeconds(delay);

            ShowInstant();
        }

        public virtual void ShowInstant()
        {
            gameObject.SetActive(true);
            Init();
        }

        public virtual void HideInstant()
        {
            gameObject.SetActive(false);
        }

        public virtual void Init()
        {
            
        }
    }
}