using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("---------- Audio Source ----------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("---------- Audio CLip ----------")]
    public AudioClip background;
    public AudioClip pop;
    public AudioClip inflate;
    public AudioClip button;
    public AudioClip bird;
    public AudioClip drone;
    public AudioClip plane;
    public AudioClip swipe;
    public AudioClip deflate;

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip) 
    {
        SFXSource.PlayOneShot(clip);
    }
}
