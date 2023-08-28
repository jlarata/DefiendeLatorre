using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class TowerController : MonoBehaviour
{
    public GameObject[] projectilesList;
    public GameObject[] targets;
    public GameObject myTarget;
    public float maxDistance = 100f;
    public float targetDistance;
    public ConstraintSource myConstraintSource;
    public AimConstraint AimConstraintComponent;

    

        void Start()
    {
        StartCoroutine(Fire());
        AimConstraintComponent = GetComponent<AimConstraint>();


    }

    void Update()
    {
        
    }

    IEnumerator Fire()
    {
            
            yield return new WaitForSeconds(1.5f);
            SetTarget();
            yield return new WaitForSeconds(1.5f);
            SpawnProjectile();

        StartCoroutine(Fire());
    }

    public void SetTarget()
        {
                
                
                targets = GameObject.FindGameObjectsWithTag ("Malos");
                
                if (targets != null)

                {
                        for (int i = 0; i< targets.Length; i++)
                        {
                                if (targets[i].activeSelf == true)

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
                }
                        //creates a ConstraintSource: it must have a sourceTransform and a weight.
                        myConstraintSource = new ConstraintSource {sourceTransform = myTarget.transform, weight = 1};
                        //uses component method "SetSource" setting the latter as a target.
                        AimConstraintComponent.SetSource(0, myConstraintSource);
                        
        }


    void SpawnProjectile()

    {
        //Instantiate(projectilesList[0], new Vector3(transform.position.x, transform.position.y -1, transform.position.z), projectilesList[0].transform.rotation);
        Instantiate(projectilesList[0], new Vector3(transform.position.x, transform.position.y -1, transform.position.z), transform.rotation);
    }
}
