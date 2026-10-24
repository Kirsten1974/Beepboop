//using UnityEngine;

//public class Cat : Enemy
//{
//    //[SerializeField] private float damage = 1.0f;

//    //[SerializeField] private WeatherManager manager;
//    private GameObject player;
//    //private PlayerDetecter playerDetecter;


//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    void Start()
//    {
//        //find weather manager //association communication + reference?
//        //manager = FindFirstObjectByType<WeatherManager?(); //establishes communication with WeatherManager
//        //helps fid the target (player)
//        player = GameObject.FindGameObjectWithTag("Player");
//        //OLD:  makes cat detect the player
//        //OLD:  playerDetecter = FindFirstObjectByType<PlayerDetecter>();

//    }

//    // Update is called once per frame
//    private void FixedUpdate()
//    {
//        if (playerDetecter.playerDetecter) { TargetPlayer(); }
//        else { Activity(); }

//    }
//    public override void Activity() //polymorphism?  changing the behaviour of an inherited function/method
//    {
//        //if it is nighttime, the cat will move.  bool in WeatherManager effects the if here
//        if (!manager.day)
//        {
//            transform.Translate(Vector2.right * Time.deltaTime * moveSpeed);

//        }
//    }
//}

