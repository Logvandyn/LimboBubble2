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
    [HideInInspector] public bool timeoff;
    float time;
    ProjShooter projShooter;

    public static Enemy instance;

    void Start()
    {
        projShooter = GetComponent<ProjShooter>();
    }

    void Update()
    {
        Move();
    }

    public void Move() //used in Update();
    {
        if (!timeoff)
        {
            time += Time.deltaTime;

            Vector3 tempPos = transform.position;
            tempPos.x = Mathf.Sin(time * Mathf.PI * 1) * 2; //1 is the speed, 2 is the distance
            transform.position = tempPos;
            
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bubble")
        {
            timeoff = true;
            projShooter.timeoff = true;
        }
    }

    private void OnTriggerExit(Collider other) //enemy is still frozen when bubble is removed...
    {
        if (other.gameObject.tag == "Bubble")
        {
            timeoff = false;
            projShooter.timeoff = false;
        }
    }

}
