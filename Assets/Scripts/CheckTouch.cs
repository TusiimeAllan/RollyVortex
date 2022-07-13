using System.Collections;
using UnityEngine;

public class CheckTouch : MonoBehaviour
{
    public Touch touch;
    public Vector2 beginTouchPosition, endTouchPosition;
    void CheckInput(){

    
        switch(touch.phase)
            {
                case TouchPhase.Began:
                beginTouchPosition = touch.position;
                break;

                case TouchPhase.Ended:
                endTouchPosition = touch.position;

                if(beginTouchPosition == endTouchPosition)
                    Debug.Log("Screen Tapped");

                if(beginTouchPosition != endTouchPosition)
                    Debug.Log("Screen Swiped");

                break;
            }
        }
}