using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameratrack : MonoBehaviour {

    Transform player;
    float offset;

    private void Start()
    {
        GameObject player_go = GameObject.FindGameObjectWithTag("Player");
        player = player_go.transform;
        offset = transform.position.x - player.position.x;
    }
    private void Update()
    {
        Vector3 pos = transform.position;
        pos.x = player.position.x + offset;
        transform.position = pos;
    }
}
