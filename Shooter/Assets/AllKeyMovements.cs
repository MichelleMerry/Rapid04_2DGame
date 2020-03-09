using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public float mSpeed;

    Vector3 mvelocity;

    void Start()
    {

    }
    private void Update()
    {
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

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0.0f, 40 * Time.deltaTime, 0.0f);

        }else if(Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0.0f, -40.0f * Time.deltaTime, 0.0f);
        }
    }
}
    
