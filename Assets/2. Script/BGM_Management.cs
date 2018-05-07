using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]

public class BGM_Management : MonoBehaviour {
    private bool isPlayed = false;

    public AudioClip SoundSfx;
    public AudioSource SoundFx;

    AudioListener listener;
    

	// Use this for initialization
	void Start () {
        SoundFx = GetComponent<AudioSource>();
        SoundFx.loop = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isPlayed == false)
        {
            if (SoundFx.isPlaying == false)
            {
                if (other.gameObject.tag == "Player")
                {
                    SoundFx.PlayOneShot(SoundSfx, 1);
                    isPlayed = true;
                }
            }
        }
    }
    
}
