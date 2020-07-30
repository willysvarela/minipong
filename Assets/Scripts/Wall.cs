﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Camera cam = Camera.main;
        EdgeCollider2D collider = GetComponent<EdgeCollider2D>();
        Vector2 bottomLeft = cam.ScreenToWorldPoint(new Vector3(0, 0, 0));
        Vector2 topLeft = cam.ScreenToWorldPoint(new Vector3(0, Screen.height, 0));
        Vector2 topRight = cam.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        Vector2 bottomRight = cam.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0));
        collider.points = new Vector2[5] { bottomLeft, topLeft, topRight, bottomRight, bottomLeft };
        Debug.Log("Altura" + bottomLeft.ToString() + " - Largura " + Screen.width.ToString());
    }

    // Update is called once per frame
    void Update()
    {

    }
}
