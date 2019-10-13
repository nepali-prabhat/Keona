using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowBounds : MonoBehaviour
{
    public bool alwaysShow = true;
    public List<GameObject> gameObjects;
    void start(){
    }
    void OnDrawGizmos()
    {
        if(alwaysShow){
            for(int i = 0; i<gameObjects.Count;i++){
                Bounds bounds = gameObjects[i].GetComponent<SpriteRenderer>().bounds;
                Gizmos.color = Random.ColorHSV(0f,1f,1f,1f,0.75f,1f);
                Gizmos.DrawWireCube(bounds.center, bounds.size);
            }
        }
    }
    void OnDrawGizmosSelected()
    {
        for(int i = 0; i<gameObjects.Count;i++){
            Bounds bounds = gameObjects[i].GetComponent<SpriteRenderer>().bounds;
            Gizmos.color = Random.ColorHSV(0f,1f,1f,1f,0.75f,1f);
            Gizmos.DrawWireCube(bounds.center, bounds.size);
        }
    }
    
}
