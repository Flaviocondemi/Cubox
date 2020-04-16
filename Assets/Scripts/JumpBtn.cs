using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems; // Required when using Event data.

public class JumpBtn : MonoBehaviour, IPointerDownHandler // required interface when using the OnPointerDown method.
{
    public void OnPointerDown(PointerEventData eventData)
    {
        SoundManager.playSound("Jump");
        TouchControl.jump = true;
    }
}