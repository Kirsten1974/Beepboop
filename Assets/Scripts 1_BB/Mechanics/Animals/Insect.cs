using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Insect : AnimalBase
{
    public GameObject lake;

    //flight control
    private float leftBound;
    private float rightBound;
    [SerializeField] private float flyRange;
    private float xDirection = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lake = GameObject.Find("Lake");
        leftBound = lake.transform.position.x - flyRange;
        rightBound = lake.transform.position.x + flyRange;
    }

    // Update is called once per frame
    void Update()
    {
        Activity();
    }

    public override void Activity()
    {
        //fly moves horizontally
        transform.Translate(Vector2.right * xDirection * moveSpeed * Time.deltaTime);
        
        //fly moves right


        if (transform.position.x <= leftBound)
        {
            xDirection = 1;
        }
            

        //fly moves left at right boundary
        else if (transform.position.x >= rightBound)
        {
            xDirection = -1;
            //transform.Translate(Vector2.left * xDirection * moveSpeed * Time.deltaTime);
        }
        
    }
}
