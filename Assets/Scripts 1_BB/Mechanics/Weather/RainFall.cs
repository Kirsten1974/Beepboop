using UnityEngine;

public class RainFall : MonoBehaviour
{
    //Controls the speed and fall of 1 rain droplet

    [SerializeField] private float baseSpeed = 1f; //speed of rain, may be adjusted in WeatherManager later
    [SerializeField] private GameObject ground;
    [SerializeField] private float groundX;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ground = GameObject.Find("Ground");
        groundX = ground.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        float finalSpeed = baseSpeed * WeatherManager.rainShower;
        //makes rain fall downwards
        transform.Translate(Vector2.down * Time.deltaTime *  finalSpeed);

        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //when the raindrop hits ground, it will be destroyed
        if (other.CompareTag("Ground"))
        {
            Destroy (gameObject);
        }
    }
}
