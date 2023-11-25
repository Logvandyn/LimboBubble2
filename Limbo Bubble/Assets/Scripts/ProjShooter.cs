using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Logan Van Dyne
 * 11/25/23
 * Projectile shooter for the enemy weapon
 */
public class ProjShooter : MonoBehaviour
{
    public GameObject projectile_prefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shoot", 0f, 0.5f); //method, float time, float repeat
    }

    public void Shoot() //spawns the bullet
    {
        Instantiate(projectile_prefab, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
    }
}
