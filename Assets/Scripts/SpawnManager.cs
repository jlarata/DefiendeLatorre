using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] enemiesList;

    public int round;

    [SerializeField]
    float spawnPosX;
    [SerializeField]
    float spawnPosY;
    [SerializeField]
    float spawnPosZ;


    //[SerializeField]
    //private bool isSpawning;

    // Start is called before the first frame update
    void Start()
    {
        round = 1;
        spawnPosX = 16.41F;
        spawnPosY = 0f;
        spawnPosZ = 5.23F;

        StartCoroutine(SpawnEnemies());

    }

    // Update is called once per frame
    void Update()
    {
   
    }

    IEnumerator SpawnEnemies()
    {
        for (var i = 0; i < round; i++)
        {
            SpawnMalo01();
            yield return new WaitForSeconds(0.5f);
        } 
        round ++;
        yield return new WaitForSeconds(4.0f);
        StartCoroutine(SpawnEnemies());
    }


    void SpawnMalo01()

    {
            Instantiate(enemiesList[0], new Vector3(spawnPosX, spawnPosY, spawnPosZ), enemiesList[0].transform.rotation);

    }

}
