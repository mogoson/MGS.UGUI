﻿/*************************************************************************
 *  Copyright © 2021 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  UIComponent.cs
 *  Description  :  Null.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  0.1.0
 *  Date         :  8/6/2021
 *  Description  :  Initial development version.
 *************************************************************************/

using UnityEngine;

namespace MGS.UGUI
{
    /// <summary>
    /// UI component.
    /// </summary>
    public abstract class UIComponent : MonoBehaviour, IUIComponent
    {
        /// <summary>
        /// The RectTransform attached to this GameObject.
        /// </summary>
        public RectTransform RTransform { get { return transform as RectTransform; } }

        /// <summary>
        /// Toggle gameObject active.
        /// </summary>
        /// <param name="isActive"></param>
        public virtual void ToggleActive(bool isActive = true)
        {
            gameObject.SetActive(isActive);
        }

        /// <summary>
        /// Toggle this Component enabled.
        /// </summary>
        /// <param name="isEnable"></param>
        public virtual void ToggleEnable(bool isEnable = true)
        {
            enabled = isEnable;
        }

        /// <summary>
        /// Destroy gameObject.
        /// </summary>
        public virtual void Destroy()
        {
            Destroy(gameObject);
        }
    }
}