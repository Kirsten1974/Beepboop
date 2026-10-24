using UnityEngine;
using UnityEngine.InputSystem;

namespace AH2707 //Sabrina_Boop
{
    public class PlayerMove : MonoBehaviour
    {

        public InputAction moveAction; //newer way to set controls
        public Vector2 moveInput; //to read input
        [SerializeField] private float speed;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            moveAction.Enable(); //Activates input to allow detection
        }

        // Update is called once per frame
        void Update()
        {
            //Reads the input from 'user' and changes movement accordingly
            moveInput = moveAction.ReadValue<Vector2>();
            //player moves left/right
            transform.Translate(Vector2.right * Time.deltaTime * moveInput.x *  speed);
            //player moves up/down
            transform.Translate(Vector2.up * Time.deltaTime * moveInput.y * speed);
        }
    }

}


