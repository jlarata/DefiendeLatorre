using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerManager : MonoBehaviour
{
    public GameObject[] towersList;

    [SerializeField]
    float spawnPosX;
    [SerializeField]
    float spawnPosY;
    [SerializeField]
    float spawnPosZ;

    public bool torresCreadasCortala;

    // Start is called before the first frame update
    void Start()
    {
        spawnPosX = 3.8F;
        spawnPosY = 1f;
        spawnPosZ = 1.13F;

        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void SpawnAllTowers()
    {
        if (!torresCreadasCortala)
        {
        SpawnTowerA();
        SpawnTowerB();
        SpawnTowerC();
        SpawnTowerD();
        SpawnTowerE();
        SpawnTowerF();
        SpawnTowerG();
        SpawnTowerH();
        SpawnTowerI();
        SpawnTowerJ();
        SpawnTowerK();
        torresCreadasCortala = true;
        }
        
    }

    public void SpawnTowerA()
    {
        spawnPosX = 12.58F;
        spawnPosY = 1f;
        spawnPosZ = 2.89F;

        Instantiate(towersList[0], new Vector3(spawnPosX, spawnPosY, spawnPosZ), towersList[0].transform.rotation);
    }
    public void SpawnTowerB()
    {
        spawnPosX = 9.52F;
        spawnPosY = 1f;
        spawnPosZ = 2.94F;

        Instantiate(towersList[0], new Vector3(spawnPosX, spawnPosY, spawnPosZ), towersList[0].transform.rotation);
    }

    public void SpawnTowerC()
    {
        spawnPosX = 3.8F;
        spawnPosY = 1f;
        spawnPosZ = 1.13F;

        Instantiate(towersList[0], new Vector3(spawnPosX, spawnPosY, spawnPosZ), towersList[0].transform.rotation);
    }
    public void SpawnTowerD()
    {
        spawnPosX = 3.8F;
        spawnPosY = 1f;
        spawnPosZ = -2.088F;

        Instantiate(towersList[0], new Vector3(spawnPosX, spawnPosY, spawnPosZ), towersList[0].transform.rotation);
    }
    public void SpawnTowerE()
    {
        spawnPosX = -0.49F;
        spawnPosY = 1f;
        spawnPosZ = -1.75F;

        Instantiate(towersList[0], new Vector3(spawnPosX, spawnPosY, spawnPosZ), towersList[0].transform.rotation);
    }
    public void SpawnTowerF()
    {
        spawnPosX = -0.89F;
        spawnPosY = 1f;
        spawnPosZ = 2.24F;

        Instantiate(towersList[0], new Vector3(spawnPosX, spawnPosY, spawnPosZ), towersList[0].transform.rotation);
    }
    public void SpawnTowerG()
    {
        spawnPosX = -0.78F;
        spawnPosY = 1f;
        spawnPosZ = 4.94F;

        Instantiate(towersList[0], new Vector3(spawnPosX, spawnPosY, spawnPosZ), towersList[0].transform.rotation);
    }
    public void SpawnTowerH()
    {
        spawnPosX = -5.95F;
        spawnPosY = 1f;
        spawnPosZ = 3.37F;

        Instantiate(towersList[0], new Vector3(spawnPosX, spawnPosY, spawnPosZ), towersList[0].transform.rotation);
    }
    public void SpawnTowerI()
    {
        spawnPosX = -6.14F;
        spawnPosY = 1f;
        spawnPosZ = -0.38F;

        Instantiate(towersList[0], new Vector3(spawnPosX, spawnPosY, spawnPosZ), towersList[0].transform.rotation);
    }
    public void SpawnTowerJ()
    {
        spawnPosX = -11.19F;
        spawnPosY = 1f;
        spawnPosZ = -0.04F;

        Instantiate(towersList[0], new Vector3(spawnPosX, spawnPosY, spawnPosZ), towersList[0].transform.rotation);
    }
    public void SpawnTowerK()
    {
        spawnPosX = -10.72F;
        spawnPosY = 1f;
        spawnPosZ = 4.99F;

        Instantiate(towersList[0], new Vector3(spawnPosX, spawnPosY, spawnPosZ), towersList[0].transform.rotation);
    }
}
