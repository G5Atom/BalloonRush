using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SoundType 
{
   BUTTON,
   POP,
   SWIPE,
   BIRD,
   DRONE,
   PLANE,
   INFLATE,
   MUSIC
}
[RequireComponent(typeof(AudioSource))]
public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioClip[] soundList;
  public static SoundManager instance;
    private AudioSource audioSource;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public static void PlaySound(SoundType sound, float volume = 1) 
    {
        instance.audioSource.PlayOneShot(instance.soundList[(int)sound], volume);
    }
}
