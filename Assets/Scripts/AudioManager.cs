using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioClip[] music;
    private AudioSource source;
    private void Start()
    {
        source = GetComponent<AudioSource>();
    }
    private void OnLevelWasLoaded(int level)
    {
        source.clip = music[level];
        source.Play();
    }
}
