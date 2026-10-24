using UnityEngine;
using UnityEngine.InputSystem;

namespace AH2707 //Sabrina_Boop
{
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
            moveAction.Enable();//
        }

        // Update is called once per frame
        void Update()
        {
            //Reads the input from 'user' and changes movement accordinly
            moveInput = moveAction.ReadValue<Vector2>();
        }
    }

}


