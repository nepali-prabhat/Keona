using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPatrol : MonoBehaviour
{
    public float minX = -6.59f;
    public float minY = -5.4f;
    public float maxX = 12.98f;
    public float maxY = 1.95f;

    public Rigidbody2D rigidBody;
    public float force = 0.5f;

    Vector2 targetPosition;
    public float speed;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        targetPosition = GetRandomPosition();
    }
    void Update()
    {
        if(targetPosition != (Vector2)transform.position){
            Vector2 dir = targetPosition - new Vector2(transform.position.x,transform.position.y);
            dir = dir.normalized;
            rigidBody.AddForce(dir*force);
        }else{
            targetPosition = GetRandomPosition();
        }
    }
    void onCollisionEnter2D(Collision2D col){
         Debug.Log("collision of ball with");
         Debug.Log(col.gameObject.name);
    }
    Vector2 GetRandomPosition(){
        float randX = Random.Range(minX,maxX);
        float randY = Random.Range(minY,maxY);
        return new Vector2(randX,randY);
    }
}
