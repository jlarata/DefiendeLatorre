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

    public bool istramo1;
    public bool istramo2;
    public bool istramo3;
    public bool istramo4;
    public bool istramo5;
    public bool istramo6;
    public bool istramo7;
    public bool istramo8;
    public bool istramo9;
    public bool istramo10;
    public bool istramo11;
    public bool istramo12;
    
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

        istramo1 = true;
    }
    void Update()
    {
         

        CheckTramo();

        MoveToPosta();

        
    }

    public void CheckTramo()
    {
        if (transform.position == posta01.transform.position)
        {
            istramo1 = false;
            istramo2 = true;
        }
        if (transform.position == posta02.transform.position)
        {
            istramo2 = false;
            istramo3 = true;
        }
        if (transform.position == posta03.transform.position)
        {
            istramo3 = false;
            istramo4 = true;
        }
        if (transform.position == posta04.transform.position)
        {
            istramo4 = false;
            istramo5 = true;
        }
        if (transform.position == posta05.transform.position)
        {
            istramo5 = false;
            istramo6 = true;
        }
        if (transform.position == posta06.transform.position)
        {
            istramo6 = false;
            istramo7 = true;
        }
        if (transform.position == posta07.transform.position)
        {
            istramo7 = false;
            istramo8 = true;
        }
        if (transform.position == posta08.transform.position)
        {
            istramo8 = false;
            istramo9 = true;
        }
        if (transform.position == posta09.transform.position)
        {
            istramo9 = false;
            istramo10 = true;
        }
        if (transform.position == posta10.transform.position)
        {
            istramo10 = false;
            istramo11 = true;
        }
        if (transform.position == posta11.transform.position)
        {
            istramo11 = false;
            istramo12 = true;
        }
        if (transform.position == posta12.transform.position)
        {
            istramo12 = false;
            Impact();
        }
        
    }
    
    public void MoveToPosta()
    {
        if (istramo1)
        {
            transform.position = Vector3.MoveTowards(transform.position, posta01.transform.position, Time.deltaTime*4);
        }
        if (istramo2)
        {
            transform.position = Vector3.MoveTowards(transform.position, posta02.transform.position, Time.deltaTime*4);
        }
        if (istramo3)
        {
            transform.position = Vector3.MoveTowards(transform.position, posta03.transform.position, Time.deltaTime*4);
        }
        if (istramo4)
        {
            transform.position = Vector3.MoveTowards(transform.position, posta04.transform.position, Time.deltaTime*4);
        }
        if (istramo5)
        {
            transform.position = Vector3.MoveTowards(transform.position, posta05.transform.position, Time.deltaTime*4);
        }
        if (istramo6)
        {
            transform.position = Vector3.MoveTowards(transform.position, posta06.transform.position, Time.deltaTime*4);
        }
        if (istramo7)
        {
            transform.position = Vector3.MoveTowards(transform.position, posta07.transform.position, Time.deltaTime*4);
        }
        if (istramo8)
        {
            transform.position = Vector3.MoveTowards(transform.position, posta08.transform.position, Time.deltaTime*4);
        }
        if (istramo9)
        {
            transform.position = Vector3.MoveTowards(transform.position, posta09.transform.position, Time.deltaTime*4);
        }
        if (istramo10)
        {
            transform.position = Vector3.MoveTowards(transform.position, posta10.transform.position, Time.deltaTime*4);
        }
        if (istramo11)
        {
            transform.position = Vector3.MoveTowards(transform.position, posta11.transform.position, Time.deltaTime*4);
        }
        if (istramo12)
        {
            transform.position = Vector3.MoveTowards(transform.position, posta12.transform.position, Time.deltaTime*4);
        }
    }

    public void Impact()
    {
        Destroy(gameObject);
    }
}
