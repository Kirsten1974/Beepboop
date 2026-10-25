using UnityEngine;
using TMPro;
namespace AH2715
{
    public class CollectionManager : MonoBehaviour
    {
        [SerializeField] private TMP_Text stickCountText; // creates a slot in inspector where the inventory text can be added
        [SerializeField] private TMP_Text redBerryCountText;
        [SerializeField] private TMP_Text blueBerryCountText;
        [SerializeField] private TMP_Text wormCountText;
        [SerializeField] private TMP_Text blackFlyCountText;

        private int stickCount;
        private int blackFlyCount;
        private int redBerryCount;
        private int blueBerryCount;
        private int wormCount;
        
       
        public void AddItem(ItemType item)
        {
            if(item == ItemType.Stick) 
            {
                stickCount++; 
                stickCountText.GetComponent<TMP_Text>().text = "" + stickCount; // adapted from a tutorial
                Debug.Log(stickCount + " " + "stick/s");
            }
            else if (item == ItemType.BlackFly)
            {
                blackFlyCount++;
                blackFlyCountText.GetComponent<TMP_Text>().text = "" + blackFlyCount;
                Debug.Log(blackFlyCount + " " + "fly/flies");
            }
            else if (item == ItemType.RedBerry)
            {
                redBerryCount++;
                redBerryCountText.GetComponent<TMP_Text>().text = "" + redBerryCount;
                Debug.Log(redBerryCount + " " + "red berry/ies");
            }
            else if (item == ItemType.BlueBerry)
            {
                blueBerryCount++;
                blueBerryCountText.GetComponent<TMP_Text>().text = "" + blueBerryCount;
                Debug.Log(blueBerryCount + " " + "blue berry/ies");
            }
            else if (item == ItemType.Worm)
            {
                wormCount++;
                wormCountText.GetComponent<TMP_Text>().text = "" + wormCount;
                Debug.Log(wormCount + " " + "worm/s");
            }
        }
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}