using UnityEngine;

namespace AH2707 //Sabrina
{
    public class FollowPlayer : MonoBehaviour
    {
        public GameObject player;
        private Vector3 offset = new Vector3 (0, 0, -10);

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            player = GameObject.Find("Player");

            Debug.Log(player);
        }

        // Update is called once per frame
        void LateUpdate()
        {
            transform.position = player.transform.position + offset; //will take player's position
        }
    }
}


