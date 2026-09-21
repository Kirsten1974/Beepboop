using UnityEngine;
namespace AH2715 
{
    public class Trampoline : MonoBehaviour
    {
        /*public GameObject sphere;
        private Rigidbody2D ball; (turned my trampoline into a trap door)*/
        private float thrust = 5f; 
        PlaySound ping;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        /* private void Awake()
         {
             ball = GetComponent<Rigidbody2D>(); is looking for the bars Rigidbody, therefore wrong approach
         }*/
        void Start()
        {
            ping = GameObject.FindGameObjectWithTag("Circle").GetComponent<PlaySound>();
        }
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Circle"))
            {
                other.attachedRigidbody.AddForce(transform.up * thrust, ForceMode2D.Impulse);
                ping.PlayAudio();
            }
            // Update is called once per frame
            /*void Update()
            {

            }

            private void FixedUpdate()
            {
                ball.AddForce(transform.up * thrust, ForceMode2D.Impulse); Accidentally worked for the trap door by keeping the bar in place
            }*/
        }
    }
   
}
