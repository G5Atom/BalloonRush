using UnityEngine;

public class Hazard : MonoBehaviour
{
    public Vector3 moveDirection;

    public float moveSpeed;
    void Update()
    {
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
}
