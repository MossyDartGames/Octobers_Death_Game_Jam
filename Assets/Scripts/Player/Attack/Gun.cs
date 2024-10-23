using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Gun : MonoBehaviour
{
    [SerializeField] Transform gunTip;
    [SerializeField] GameObject bullet;
    [SerializeField] float bulletSpeed = 20f;

    private void Shoot()
    {
        GameObject b = Instantiate(bullet, gunTip.position, gunTip.rotation);
        Rigidbody rb = b.GetComponent<Rigidbody>();
        if (rb != null )
        {
            rb.velocity = gunTip.forward * bulletSpeed;
        }
        
    }

}
