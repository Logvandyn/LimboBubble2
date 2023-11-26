using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Logan Van Dyne
 * 11/23/23
 * Enemy Movement
 */
public class Enemy : MonoBehaviour
{
    public bool inBubble = false;
    public bool timeoff = false;

    // Update is called once per frame
    void Update()
    {
        Move();
        SetTime();
    }

    public Vector3 pos //used in Move();
    {
        get
        {
            return this.transform.position;
        }
        set
        {
            this.transform.position = value;
        }
    }
    public void Move() //used in Update();
    {
        //if (inBubble == false)
        //{
            Vector3 tempPos = pos; 
            tempPos.x = Mathf.Sin(Time.time * Mathf.PI * 1) * 2; //1 is the speed, 2 is the distance
            pos = tempPos;
        //}
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bubble")
        {
            //this.GetComponent<Rigidbody>().isKinematic = true;
            //inBubble = true;
            timeoff = true;
        }
    }

    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Bubble")
        {
            //this.GetComponent<Rigidbody>().isKinematic = false;
            //inBubble = false;
            timeoff = false;
        }
    }

    private void SetTime()
    {
        if (timeoff == true)
        {
            Time.timeScale = 0;
        }
        if (timeoff == false)
        {
            Time.timeScale = 1;
        }
    }

}
