using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using WinTween;
using WinTween.Position;
using static WinTween.WindowCore;

public class WinTest : MonoBehaviour
{
    private void Start()
    {
        Middle(0, true);
        ResetPositionVar();

        Debug.Log("Mid " + MiddleCenter);
        Debug.Log("TopLeft " + TopLeft);
        Debug.Log("BottomRight " + BottomRight);
        Debug.Log("Current " + Position.Location);
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            Position.Move(TopLeft, 4.0f, false, () => Debug.Log("다 움직임"));
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            Position.Move(BottomRight, 4.0f, false, () => Debug.Log("다 움직임"));
        }

        
    }

}