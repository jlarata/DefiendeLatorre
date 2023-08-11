using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerController : MonoBehaviour
{
    public GameObject[] projectilesList;
    // Start is called before the first frame update
    void Start()
    {
            StartCoroutine(Fire());

    }

    void Update()
    {
        
    }

    IEnumerator Fire()
    {
            
            yield return new WaitForSeconds(3f);
            SpawnProjectile();

        StartCoroutine(Fire());
    }


    void SpawnProjectile()

    {
            Instantiate(projectilesList[0], new Vector3(transform.position.x, transform.position.y -1, transform.position.z), projectilesList[0].transform.rotation);

    }
}
