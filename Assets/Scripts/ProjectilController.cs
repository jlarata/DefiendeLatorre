using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilController : MonoBehaviour
{
    public float xRandomDirection;
    public float zRandomDirection;
    public Vector3 randomDirection;

    public float xBoundary;
    public float zBoundaryBot;
    public float zBoundaryTop;

        void Start()
    {
        xRandomDirection = Random.Range(-1f, 1f);
        zRandomDirection = Random.Range(-1f, 1f);
        randomDirection.x = xRandomDirection;
        randomDirection.z = zRandomDirection;
        xBoundary = 17.0f;
        zBoundaryTop = 7.0f;
        zBoundaryBot = 3.07f;
    }
      void Update()
    {
        WeaponBehaviour();
    }

    public void WeaponBehaviour()
    {
        transform.Translate(randomDirection * Time.deltaTime * 6, Space.World);

        if (transform.position.x > xBoundary || transform.position.x < -xBoundary)
        {
            Destroy(gameObject);
        }

        if (transform.position.z < -zBoundaryBot || transform.position.z > zBoundaryTop)
        {
            Destroy(gameObject);
        }
        

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Malos")
        {

        other.GetComponent<MaloController>().Impact();
        Destroy(gameObject);
        }
        
    }

}
