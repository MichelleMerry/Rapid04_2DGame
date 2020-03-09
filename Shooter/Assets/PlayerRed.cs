using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRed : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public float mSpeed;

    Vector3 mvelocity;



    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

        mvelocity = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            mvelocity.z = 1.0f;

        }
        else if (Input.GetKey(KeyCode.S))
        {
            mvelocity.z = -1.0f;

        }
        if (Input.GetKey(KeyCode.D))
        {
            mvelocity.x = -1.0f;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            mvelocity.x = 1.0f;
        }
        transform.Translate(mvelocity.normalized * Time.deltaTime * mSpeed);








    }
    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
