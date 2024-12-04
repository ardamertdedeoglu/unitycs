using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private void Update()
    {
        // Oyuncu W tusuna basiyor ise
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0,0,1) * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0,0,-1) * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(1,0,0) * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-1,0,0) * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftControl)) 
        { 
            transform.position += new Vector3(0, -1, 0) * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += new Vector3(0, 1, 0) * speed * Time.deltaTime;
        }
    }
}
