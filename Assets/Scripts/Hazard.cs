using UnityEngine;

public class Hazard : MonoBehaviour
{
    public enum HazardType
    {
        Bird,
        Plane,
        Drone,
    }

    [Header("Movement")]
    public Vector3 moveDirection;
    public float moveSpeed;

    [Header("Hazard Settings")]
    public HazardType hazardType;

    private void Start()
    {
        PlayHazardSound();
        Destroy(gameObject, 10f);
    }

    void Update()
    {
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }

    void PlayHazardSound()
    {
        AudioManager audioManager = FindAnyObjectByType<AudioManager>();
        if (audioManager == null)
        {
            Debug.LogWarning("AudioManager not found in scene.");
            return;
        }

        AudioClip clipToPlay = null;

        switch (hazardType)
        {
            case HazardType.Bird:
                clipToPlay = audioManager.bird;
                break;
            case HazardType.Plane:
                clipToPlay = audioManager.plane;
                break;
            case HazardType.Drone:
                clipToPlay = audioManager.drone;
                break;
            default:
                Debug.Log("No matching sound for hazard type.");
                break;
        }

        if (clipToPlay != null)
        {
            audioManager.PlaySFX(clipToPlay);
        }
    }
}

