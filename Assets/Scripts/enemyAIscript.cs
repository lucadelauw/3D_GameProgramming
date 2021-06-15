using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAIscript : MonoBehaviour
{
    public Transform player;
    public float playerDistance;
    public float rotationDamping;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerDistance = Vector3.Distance(player.position, transform.position);

        if(playerDistance < 15f) 
        {
            lookAtPlayer();
        }
        if (playerDistance < 12f) 
        {
            Chase();
        }
    }
    void lookAtPlayer() 
    {
        Quaternion rotation = Quaternion.LookRotation(player.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotationDamping);
    }
    void Chase() 
    {
        transform.Translate(Vector3.forward * moveSpeed*  Time.deltaTime);
    }
}
