using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaloController : MonoBehaviour
{

    public GameObject posta01;
    public GameObject posta02;
    public GameObject posta03;
    public GameObject posta04;
    public GameObject posta05;
    public GameObject posta06;
    public GameObject posta07;
    public GameObject posta08;
    public GameObject posta09;
    public GameObject posta10;
    public GameObject posta11;
    public GameObject posta12;

    public int currentTramo;

    
    void Start()
    {

        posta01 = GameObject.Find("Posta01");
        posta02 = GameObject.Find("Posta02");
        posta03 = GameObject.Find("Posta03");
        posta04 = GameObject.Find("Posta04");
        posta05 = GameObject.Find("Posta05");
        posta06 = GameObject.Find("Posta06");
        posta07 = GameObject.Find("Posta07");
        posta08 = GameObject.Find("Posta08");
        posta09 = GameObject.Find("Posta09");
        posta10 = GameObject.Find("Posta10");
        posta11 = GameObject.Find("Posta11");
        posta12 = GameObject.Find("Posta12");

        currentTramo = 1;
    }
    void Update()
    {
         

        CheckTramo();

        MoveToPosta();

        
    }

    public void CheckTramo()
    {
        if (transform.position == posta01.transform.position || 
        transform.position == posta02.transform.position || 
        transform.position == posta03.transform.position || 
        transform.position == posta04.transform.position || 
        transform.position == posta05.transform.position || 
        transform.position == posta06.transform.position || 
        transform.position == posta07.transform.position || 
        transform.position == posta08.transform.position || 
        transform.position == posta09.transform.position || 
        transform.position == posta10.transform.position || 
        transform.position == posta11.transform.position)
        {
            currentTramo += 1;
        }
        
        
        if (transform.position == posta12.transform.position)
        {
            currentTramo += 1;
            Impact();
        }
    }

    
    
    public void MoveToPosta()
    {
        if (currentTramo == 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, posta01.transform.position, Time.deltaTime*2);
        }
        if (currentTramo == 2)
        {
            transform.position = Vector3.MoveTowards(transform.position, posta02.transform.position, Time.deltaTime*2);
        }
        if (currentTramo == 3)
        {
            transform.position = Vector3.MoveTowards(transform.position, posta03.transform.position, Time.deltaTime*2);
        }
        if (currentTramo == 4)
        {
            transform.position = Vector3.MoveTowards(transform.position, posta04.transform.position, Time.deltaTime*2);
        }
        if (currentTramo == 5)
        {
            transform.position = Vector3.MoveTowards(transform.position, posta05.transform.position, Time.deltaTime*2);
        }
        if (currentTramo == 6)
        {
            transform.position = Vector3.MoveTowards(transform.position, posta06.transform.position, Time.deltaTime*2);
        }
        if (currentTramo == 7)
        {
            transform.position = Vector3.MoveTowards(transform.position, posta07.transform.position, Time.deltaTime*2);
        }
        if (currentTramo == 8)
        {
            transform.position = Vector3.MoveTowards(transform.position, posta08.transform.position, Time.deltaTime*2);
        }
        if (currentTramo == 9)
        {
            transform.position = Vector3.MoveTowards(transform.position, posta09.transform.position, Time.deltaTime*2);
        }
        if (currentTramo == 10)
        {
            transform.position = Vector3.MoveTowards(transform.position, posta10.transform.position, Time.deltaTime*2);
        }
        if (currentTramo == 11)
        {
            transform.position = Vector3.MoveTowards(transform.position, posta11.transform.position, Time.deltaTime*2);
        }
        if (currentTramo == 12)
        {
            transform.position = Vector3.MoveTowards(transform.position, posta12.transform.position, Time.deltaTime*2);
        }
    }

    public void Impact()
    {
        Destroy(gameObject);
    }
}
