using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Logan Van Dyne
 * 11/23/23
 * Enemy Projectile
 */

public class Projectile : MonoBehaviour
{
    public int laserSpeed = 5;
    [HideInInspector] public bool timeoff;

    void Update()
    {
        if(!timeoff)
            transform.position += Vector3.up * Time.deltaTime * laserSpeed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ceiling")
            Destroy(this.gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bubble")
            timeoff = true;
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Bubble")
            timeoff = false;
    }
}
