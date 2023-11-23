using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Logan Van Dyne
 * 11/23/23
 * Enemy Movement & Projectile Shooting
 */
public class Enemy : MonoBehaviour
{
    public bool inBubble = false;

    private void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
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
    public virtual void Move() //used in Update();
    {
        if (inBubble == false)
        {
            Vector3 tempPos = pos; 
            tempPos.x = Mathf.Sin(Time.time * Mathf.PI * 1) * 2;
            pos = tempPos;
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bubble")
        {
            inBubble = true;
        }
    }

    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Bubble")
        {
            inBubble = false;
        }
    }

}
