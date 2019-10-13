using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnInArea : MonoBehaviour
{
    public SpriteRenderer SpawnBoundBox;
    
    private List<GameObject> dynamicLetters;
    void Start()
    {
        dynamicLetters = GetComponent<DynamicLetterGenerator>().generatedLetters;

    }

    void Update()
    {
        
    }
    private void getRandomPoints(){
        
    } 
    
}
