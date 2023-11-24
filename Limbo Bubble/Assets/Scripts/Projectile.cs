using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Logan Van Dyne
 * 11/23/23
 * Enemy Projectile
 */

public class Projectile : MonoBehaviour
{
    public int laserSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * Time.deltaTime * laserSpeed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ceiling")
        {
            //this.gameObject.SetActive(false); doesnt actually destroy, just hides it
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "Bubble")
        {
            this.GetComponent<Rigidbody>().isKinematic = true;
        }
        
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Bubble")
        {
            this.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
