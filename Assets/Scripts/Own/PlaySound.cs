using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PlaySound : MonoBehaviour
{
    public AudioClip sound;
    private AudioSource _audioSound;
    /* plays a sound, when the "ball" hits the floor (trigger collider)
     */
    //Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
       _audioSound = GetComponent<AudioSource>();
    }
    void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.gameObject.CompareTag("Circle")) (this part is only needed, if other things could be the trigger)
        {
           _audioSound.clip = sound;
            _audioSound.Play(0);
        }
    }
    // Update is called once per frame
    void Update()
    {
      
    }
}
