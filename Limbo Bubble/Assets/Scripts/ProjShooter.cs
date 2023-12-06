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
    public float delay;
    [HideInInspector] public bool timeoff;
    float timer;

    public static ProjShooter instance;

    void Start()
    {
        timer = delay;
    }

    void Update()
    {
        if(!timeoff)
            timer = Mathf.Max(timer - Time.deltaTime, 0);

        if (timer == 0)
            Shoot();
    }

    public void Shoot() //spawns the bullet
    {
        Instantiate(projectile_prefab, transform.position + Vector3.up, transform.rotation);
        timer = delay;
    }
}
