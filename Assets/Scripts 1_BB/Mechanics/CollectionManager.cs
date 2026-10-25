using UnityEngine;
namespace AH2715
{
    public class CollectionManager : MonoBehaviour
    {
        //private bool canFly = false;
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
                Debug.Log(stickCount + " " + "stick/s");
            }
            else if (item == ItemType.BlackFly)
            {
                blackFlyCount++;
                Debug.Log(blackFlyCount + " " + "fly/flies");
            }
            else if (item == ItemType.RedBerry)
            {
                redBerryCount++;
                Debug.Log(redBerryCount + " " + "red berry/ies");
            }
            else if (item == ItemType.BlueBerry)
            {
                blueBerryCount++;
                Debug.Log(blueBerryCount + " " + "blue berry/ies");
            }
            else if (item == ItemType.Worm)
            {
                wormCount++;
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