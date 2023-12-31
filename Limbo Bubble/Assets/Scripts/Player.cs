using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Logan Van Dyne
 * 11/30/23
 * Player spawner to create the bubble
 */
public class Player : MonoBehaviour
{
    //Spawn the bubble on mouse location when clicked
    //If the player clicks again while the bubble is active, deactivate the bubble 
    public bool BubbleActive = false;
    public GameObject BubblePrefab;
    public GameObject BubbleObj; //object to destroy

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (BubbleActive == false)
            {
                Vector3 mousePos = Input.mousePosition; //get mouse position
                mousePos.z = 10; //lock spawn to a Z coordinate so it stays in the room
                Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos); //get the position of the mouse in the world
                //Instantiate(BubblePrefab, worldPos, Quaternion.identity);
                BubbleObj = Instantiate(BubblePrefab, worldPos, Quaternion.identity); //spawn bubble at mouse location (new obj to destroy)
                BubbleActive = true;
            }
            else
            {
                //Bubble.instance.End();

                //Destroy(BubbleObj.gameObject); //had to create a new object- attempted to destroy prefabs (not permitted)
                //instead of destroying object, make it shrink incredibly fast! This way the collision exit still applies and doesn't cause enemy freezing
                Bubble.instance.Duration = 0.1f;
                BubbleActive = false;

                //Enemy Freezing Fix
                //Enemy.instance.timeoff = false;
                //ProjShooter.instance.timeoff = false;

            }
            
        }
    }
}
