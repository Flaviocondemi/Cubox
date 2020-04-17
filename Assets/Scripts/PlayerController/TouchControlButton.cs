using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchControlButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IMoveHandler
{
    public static bool move = false;
    public static int axisValue;
    public string axisRow;
    public void OnPointerDown(PointerEventData eventData)
    {
        if (axisRow == "Right")
        {
            move = true;
            axisValue = 1;
        }else if(axisRow == "Left")
        {
            move = true;
            axisValue = -1;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        move = false;
        axisValue = 0;
    }

    public void OnMove(AxisEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public static void resetAxisValue()
    {
        axisValue = 0;
    }

    public static bool isMoving()
    {
        return move;
    }
}
