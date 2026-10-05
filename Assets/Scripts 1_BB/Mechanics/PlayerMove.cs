using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    //Value based variabs
    [SerializeField] private float speed;
    //[SerializeField] private float turnSpeed;  //do we need this in vector 2?

    //Input system write and read
    [SerializeField] InputAction moveAction; //newer way to set controls
    public Vector2 moveInput; //to read input
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //turnSpeed = speed * 4; //this was a speed I liked before, not relavant in 2D
        moveAction.Enable();//
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
