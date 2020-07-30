using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float Velocity = 0.05f;
    float limitY;
    void Start()
    {
        limitY = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height, 0)).y;

    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.CompareTag("Player1"))
        {

            if (Input.GetKey(KeyCode.Q))
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + Velocity, transform.position.z);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - Velocity, transform.position.z);
            }
        }

        if (this.gameObject.CompareTag("Player2"))
        {

            if (Input.GetKey(KeyCode.O))
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + Velocity, transform.position.z);
            }
            if (Input.GetKey(KeyCode.L))
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - Velocity, transform.position.z);
            }
        }

        float newPositionY = Mathf.Clamp(transform.position.y, -limitY, limitY);
        transform.position = new Vector3(transform.position.x, newPositionY, transform.position.z);

    }
}
