using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    [SerializeField] private float swipeThreshold = 0.5f;

    private Vector3 tapStartPosition = Vector3.zero;
    private Vector3 tapEndPosition = Vector3.zero;

    public delegate void OnTapHandler();
    public static event OnTapHandler OnTap;

    public delegate void OnSwipeHandler(string direction);
    public static event OnSwipeHandler OnSwipe;
    public void Tap(InputAction.CallbackContext tap) 
    {
        if (tap.started == true)
        {
            //Debug.Log("Tap has started");
            tapStartPosition = GetTapPosition();
        }
        else if (tap.canceled == true) 
        {
            //Debug.Log("Tap has finished");
            tapEndPosition = GetTapPosition();
            CheckForSwipe();
            OnTap?.Invoke();
        }
    }

    private Vector3 GetTapPosition() 
    {
        Vector3 pointerPosition = Pointer.current.position.ReadValue();

        return pointerPosition;
    }

    private void CheckForSwipe() 
    {
        Vector3 tapStartWorldPosition = tapStartPosition;
        tapStartWorldPosition.z = 1f;
        tapStartWorldPosition = Camera.main.ScreenToWorldPoint(tapStartWorldPosition);

        Vector3 tapEndWorldPosition = tapEndPosition;
        tapEndWorldPosition.z = 1f; 
        tapEndWorldPosition = Camera.main.ScreenToWorldPoint(tapEndWorldPosition);

        float distanceSwiped = Vector3.Distance(tapStartWorldPosition, tapEndWorldPosition);

        if (distanceSwiped >= swipeThreshold) 
        {
            string direction = "";

            float horizontalSwipe = tapEndPosition.x - tapStartPosition.x;
            float verticalSwipe = tapEndPosition.y - tapStartPosition.y;

            if (Mathf.Abs(horizontalSwipe) > Mathf.Abs(verticalSwipe)) 
            {
                if (horizontalSwipe > 0) 
                {
                    direction = "right";
                }
                else
                {
                    direction = "left";
                }

                //Debug.Log(direction);
                OnSwipe?.Invoke(direction);
            }
        }
    }
}
