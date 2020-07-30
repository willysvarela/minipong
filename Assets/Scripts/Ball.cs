using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public float Velocity = 10;
    public Vector3 Direction;
    public Text Player1Point;
    public Text Player2Point;
    public GameObject WinText;

    public AudioSource BlopSound;
    public AudioSource WinSound;
    // Start is called before the first frame update
    void Start()
    {
        Direction.Normalize();
        WinText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Direction * Velocity * Time.deltaTime;
        transform.Rotate(0, 0, 0.1f);
    }


    void OnCollisionEnter2D(Collision2D other)
    {
        Vector2 normal = other.contacts[0].normal;
        if (other.gameObject.CompareTag("Wall"))
        {
            Direction.Normalize();
        }
        if (other.gameObject.CompareTag("WallP1"))
        {
            //Ponto do jogador 2
            transform.position = new Vector3(0, 0, 0);
            Player2Point.text = (int.Parse(Player1Point.text) + 1).ToString();
            WinSound.Play();
        }
        if (other.gameObject.CompareTag("WallP2"))
        {
            //Ponto do jogador 1
            transform.position = new Vector3(0, 0, 0);
            Player1Point.text = (int.Parse(Player1Point.text) + 1).ToString();
            WinSound.Play();
        }

        if (other.gameObject.CompareTag("Player1") || other.gameObject.CompareTag("Player2"))
        {
            BlopSound.Play();
            Velocity += 0.1f;
        }

        if (Player1Point.text == "10")
        {
            WinText.GetComponent<Text>().text = "P1 Ganhou :D";
            WinText.gameObject.SetActive(true);
        }
        if (Player1Point.text == "10")
        {
            WinText.GetComponent<Text>().text = "P2 Ganhou :D";
            WinText.gameObject.SetActive(true);
        }
        Direction = Vector2.Reflect(Direction, normal);
        Direction.Normalize();

    }
}
