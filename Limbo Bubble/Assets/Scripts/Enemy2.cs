using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Logan Van Dyne
 * 11/23/23
 * Enemy Movement# 2: Attempting bug fix
 */

/// <summary>
/// PROBLEMS: Original enemy script snaps the enemy back to the center when inBubble = false;
/// The preferred method is to continue where it froze, not restart 
/// Researched solution may help; results pending
/// </summary>
public class Enemy2 : MonoBehaviour
{
    public float speed = 1.19f;
    Vector3 pointA;
    Vector3 pointB;

    public bool inBubble = false;

    void Start()
    {
        pointA = new Vector3(5, 0, 0);
        pointB = new Vector3(-5, 0, 0);
    }

    void Update()
    {
        Move();
    }

    public void Move() //used in Update();
    {
        if (inBubble == false)
        {
            //PingPong between 0 and 1
            float time = Mathf.PingPong(Time.time * speed, 1);
            transform.position = Vector3.Lerp(pointA, pointB, time);
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
