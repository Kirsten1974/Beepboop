using UnityEngine;
namespace AH2715
{

    public class CollectItem : MonoBehaviour, ICollectible
    {
        [SerializeField] ItemType itemType;
        CollectionManager count;
        void Start()
        {
            count = FindFirstObjectByType<CollectionManager>();
        }
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                Collect();
            }    
        }

        public void Collect()
        {
            count.AddItem(itemType);
           Destroy(gameObject);
        }
    }
    public enum ItemType
    {
        Stick,
        RedBerry,
        BlueBerry,
        BlackFly,
        Worm,


           
    }
}