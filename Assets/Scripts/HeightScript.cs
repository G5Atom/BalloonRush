using UnityEngine;

public class HeightScript : MonoBehaviour
{
    [SerializeField]
    private Vector3 moveDirection;
    [SerializeField]
    private float moveSpeed;
    void Update()
    {
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
}
