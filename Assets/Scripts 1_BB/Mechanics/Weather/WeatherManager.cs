using Unity.VisualScripting;
using UnityEngine;

public class WeatherManager : MonoBehaviour
{
    //This script will control weather (rain) and day/night
    
    //Day and night
    public bool day; //this info needs a return for other objects


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating(nameof(SetRaining), 2f, 5f); //checks bool method for if it is raining
        day = false;//needs to be fixed next, set to night to check cat
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isRaining) SpawnRain(); //in update if it is raining, it will spawn the rain
    }


    //Rain systems
    [SerializeField] public static float rainShower; //control how hard it rains, not sure why it only works with static
    public int weather; //randomized int return causes rain
    public bool isRaining; //determines yes or no for if it is raining
    [SerializeField] public GameObject rainPrefab;

    public void SetRaining() //will determine if it is raining or not
    {
        weather = Random.Range(0, 2);

        if (weather == 0) isRaining = false;
        else isRaining = true; 
    }

    void SpawnRain()
    {
        //define x and y range values for where rain should instantiate
        float xArea = 4f;
        float yArea = 4f;
        //Determines spawning area/range
        Vector2 spawnPos = new Vector2(Random.Range(-xArea, xArea), Random.Range(-yArea, yArea));
        //Actually instantiates the rain prefab here
        Instantiate(rainPrefab, spawnPos, Quaternion.identity);


    }


}
