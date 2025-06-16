using UnityEngine;

public class BalloonController : MonoBehaviour
{
    public float laneDistance = 2f;  // Distance between lanes
    private int currentLane = 0;     // -1 (left), 0 (middle), 1 (right)
    private Vector3 targetPosition;

    void Start()
    {
        targetPosition = transform.position;
    }

    void Update()
    {
        // Check for swipe input
        if (SwipeManager.swipeLeft && currentLane > -1)
        {
            currentLane--;
            UpdateTargetPosition();
        }
        else if (SwipeManager.swipeRight && currentLane < 1)
        {
            currentLane++;
            UpdateTargetPosition();
        }

        // Smooth transition to target lane position (Y stays the same)
        Vector3 newPosition = new Vector3(targetPosition.x, transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, newPosition, 10f * Time.deltaTime);
    }

    void UpdateTargetPosition()
    {
        targetPosition = new Vector3(currentLane * laneDistance, transform.position.y, transform.position.z);
    }
}

