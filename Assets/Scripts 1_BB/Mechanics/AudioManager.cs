using AH2715;
using System.Net.NetworkInformation;
using UnityEngine;
public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource beep;
    [SerializeField] AudioClip test;
    [SerializeField] GameObject player;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        beep.PlayOneShot(test);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
;