using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicLetterGenerator : MonoBehaviour
{
    public enum GameMode{
        Consonents,
        Vowels,
        Numbers
    }
    public SpriteRenderer spawnBoundBox;
    public GameObject letterContainerRef;
    public GameMode gameMode = GameMode.Consonents;
    public List<int> gameLettersRelativeIndex;

    public GameObject letterSprites;
    private SpriteRenderer[] letterSpriteRenderers;

    public List<GameObject> generatedLetters;
    
    void Start()
    {
        letterSpriteRenderers = letterSprites.GetComponentsInChildren<SpriteRenderer>(true);
        instantiateLetters();
    }
    private void instantiateLetters(){
        foreach(int index in gameLettersRelativeIndex){
            Vector3 position = getUniqueRandomPosition();
            GameObject newObject = Instantiate(letterContainerRef, position, Quaternion.identity);
            //change the sprite
            SpriteRenderer[] childrenSR = newObject.GetComponentsInChildren<SpriteRenderer>();
            foreach(SpriteRenderer sr in childrenSR){
                if(sr.name == "letter"){
                    sr.sprite = letterSpriteRenderers[index].sprite;
                }
            }
            //change the name
            newObject.name = $"GameLetter";
            //change the position
            generatedLetters.Add(newObject);
        }
    }
    private Vector3 getUniqueRandomPosition(){
        float minX = spawnBoundBox.bounds.min.x;
        float minY = spawnBoundBox.bounds.min.y;
        float maxX = spawnBoundBox.bounds.max.x;
        float maxY = spawnBoundBox.bounds.max.y;
        return new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), 0);
    }
}
