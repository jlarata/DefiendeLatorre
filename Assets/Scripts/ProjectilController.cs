using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilController : MonoBehaviour
{
    public float xRandomDirection;
    public float zRandomDirection;
    public Vector3 randomDirection;
        void Start()
    {
        xRandomDirection = Random.Range(-1f, 1f);
        zRandomDirection = Random.Range(-1f, 1f);
        randomDirection.x = xRandomDirection;
        randomDirection.z = zRandomDirection;
        
    }
    
    // TENGO QUE HACER UN METODO DE AUTODESTROY SI SE SALE DE LOS BONDS!!!

    // Update is called once per frame
    void Update()
    {
        WeaponBehaviour();
    }

    public void WeaponBehaviour()
    {
        transform.Translate(randomDirection * Time.deltaTime * 6, Space.World);

        /*if (transform.position.x > xRange || transform.position.x < -xRange)
        {
            setNewDirection();
        }

        if (transform.position.y < -yRange || transform.position.y > yRange)
        {
            setNewDirection();
        }*/
        

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
