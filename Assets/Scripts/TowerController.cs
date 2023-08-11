using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerController : MonoBehaviour
{
    public GameObject[] projectilesList;
    public GameObject[] targets;
    public GameObject myTarget;
    public float maxDistance = 100f;
    public float targetDistance;

    

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
            SetTarget();
            yield return new WaitForSeconds(.5f);
            SpawnProjectile();

        StartCoroutine(Fire());
    }

    public void SetTarget()
        {
                targets = GameObject.FindGameObjectsWithTag ("Malos");
                
                for (int i = 0; i< targets.Length; i++)
                {
                        // iteration: for each enemy calculate distance to tower
                        targetDistance = Vector3.Distance(targets[i].transform.position, transform.position);
                        // then if that distance is less than "maxdistance" (it should say mindistance)
                        if (targetDistance < maxDistance)
                        {
                                //resets the maxdistance (so to check other objects)
                        maxDistance = targetDistance;
                        //and sets the current target
                        myTarget = targets[i];
                
                        }
                        }
        }


    void SpawnProjectile()

    {
            Instantiate(projectilesList[0], new Vector3(transform.position.x, transform.position.y -1, transform.position.z), projectilesList[0].transform.rotation);

    }
}
