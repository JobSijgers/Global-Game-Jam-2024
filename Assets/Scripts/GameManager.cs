using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private AudioSource source;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
        source = GetComponent<AudioSource>();
    }
    public void ApplyAudio(float value)
    {
        source.volume = value;
    }
}
