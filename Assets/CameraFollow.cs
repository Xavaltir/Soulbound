﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform player;
    private float distance = 0f;
     private void Update()
    {
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
    }

}
