using UnityEngine;

public class ChangeDirection : MonoBehaviour
{

    private Transform mover;

    private void Start()
    {
        mover = GetComponent<Transform>();
    }
    private void OnEnable()
    {
        //InputManager.OnTap += ProcessTap;
        InputManager.OnSwipe += ProcessSwipe;
    }

    private void OnDisable()
    {
       // InputManager.OnTap -= ProcessTap;
        InputManager.OnSwipe -= ProcessSwipe;
    }

    //private void ProcessTap() 
    //{
        //if (transform.material.color == Color.white)
        //{
           // rend.material.color = Color.red;
       // }
        //else 
       // {
            //rend.material.color = Color.white;
        //}
    //}

    private void ProcessSwipe(string direction) 
    {
        switch (direction) 
        {
            case "right":
                transform.material.color = Color.white;
                break;
            case "left":
                transform.material.color = Color.cyan;
                break;
        } 
    }
}
