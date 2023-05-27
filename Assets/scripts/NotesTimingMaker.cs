using UnityEngine;
using System.Collections;

public class NotesTimingMaker : MonoBehaviour
{

    private AudioSource _audioSource;

    public GameObject startButton;

    void Start()
    {
        _audioSource = GameObject.Find("GameMusic").GetComponent<AudioSource>();
    }

    void Update()
    {

    }

    public void StartMusic()
    {
        startButton.SetActive(false);
        _audioSource.Play();
    }
}