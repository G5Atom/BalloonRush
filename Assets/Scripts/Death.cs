using UnityEngine;

public class Death : MonoBehaviour
{
    public bool isDead;
    [SerializeField] private GameObject deathscreen;

    public void OnTriggerEnter2D(Collider2D other)

    {
        if (other.gameObject.CompareTag("Hazard"))
        {
            Debug.Log("Touched by Hazard");
            isDead = true;
        }
    }

    private void Start()
    {
        isDead = false;
        deathscreen.SetActive(false);
    }

    private void Update()
    {
        if (isDead)
        {
            deathscreen.SetActive(true);
        }
    }
}
