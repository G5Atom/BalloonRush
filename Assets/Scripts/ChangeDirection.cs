using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class ChangeDirection : MonoBehaviour
{
    [SerializeField] private float swipeDistance = 2f;

    private Transform mover;
    [SerializeField]
    private float jumpForce;
    private Rigidbody2D balloonRB;
    private bool isJumping;

    public Vector3 moveDirection;

    public float moveSpeed;

    private void Start()
    {
        mover = GetComponent<Transform>();
        balloonRB = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
    private void OnEnable()
    {
        InputManager.OnTap += ProcessTap;
        InputManager.OnSwipe += ProcessSwipe;
    }

    private void OnDisable()
    {
        InputManager.OnTap -= ProcessTap;
        InputManager.OnSwipe -= ProcessSwipe;
    }

    private void ProcessTap()
    {
        Jump();
    }

    private void ProcessSwipe(string direction)
    {
        switch (direction)
        {
            case "right":
                transform.position += new Vector3(swipeDistance, 0, 0);
                break;
            case "left":
                transform.position += new Vector3(-swipeDistance, 0, 0);
                break;
        }
    }

    private void Jump()
    {
        if (!isJumping)
        {
            StartCoroutine(JumpCoolDown());
        }
    }

    IEnumerator JumpCoolDown()
    {
        balloonRB.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        isJumping = true;
        yield return new WaitForSeconds(.3f);
        balloonRB.linearVelocity = Vector3.zero;
        isJumping = false;
    }
}
