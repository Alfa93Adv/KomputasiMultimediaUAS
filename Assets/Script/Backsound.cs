using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backsound : MonoBehaviour {
	public AudioClip clipSatu;
    AudioSource audioSource;
    void Awake(){
        audioSource = GetComponent<AudioSource>();
    }
               
    void Start(){
        audioSource.clip = clipSatu;
        audioSource.Play();
    }
}
