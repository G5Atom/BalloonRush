using UnityEngine;

public class SwipeManager : MonoBehaviour
{
    public static bool swipeLeft, swipeRight;

    private bool isDragging;
    private Vector2 startTouch, swipeDelta;

    void Update()
    {
        swipeLeft = swipeRight = false;

        if (Input.GetMouseButtonDown(0))
        {
            isDragging = true;
            startTouch = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            DetectSwipe();
            Reset();
        }

        if (Input.touchCount > 0)
        {
            if (Input.touches[0].phase == TouchPhase.Began)
            {
                isDragging = true;
                startTouch = Input.touches[0].position;
            }
            else if (Input.touches[0].phase == TouchPhase.Ended)
            {
                DetectSwipe();
                Reset();
            }
        }
    }

    void DetectSwipe()
    {
        swipeDelta = Vector2.zero;

        if (isDragging)
        {
            if (Input.touchCount > 0)
                swipeDelta = Input.touches[0].position - startTouch;
            else
                swipeDelta = (Vector2)Input.mousePosition - startTouch;

            if (swipeDelta.magnitude > 50)
            {
                if (Mathf.Abs(swipeDelta.x) > Mathf.Abs(swipeDelta.y))
                {
                    swipeLeft = swipeDelta.x < 0;
                    swipeRight = swipeDelta.x > 0;
                }
            }
        }
    }

    void Reset()
    {
        isDragging = false;
        startTouch = swipeDelta = Vector2.zero;
    }
}
