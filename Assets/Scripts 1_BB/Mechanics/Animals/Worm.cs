using UnityEngine;

public class Worm : AnimalBase
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void Activity()
    {
        //subscribes to weather
        //instantiate if rain
        //moves
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
    }
}
