using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public bool isometric;
    public bool subiendo;
    public bool bajando;

    // Start is called before the first frame update
    void Start()
    {
        isometric = false;
        subiendo = false;
        bajando = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            ChangeCamera();
        }

        if (subiendo == true)
        {
            if (transform.position.y < 14)
            {transform.Translate(Vector3.up * Time.deltaTime *2, Space.World);}
            if (transform.position.x < -0.5f)
            {transform.Translate(Vector3.right * Time.deltaTime *2, Space.World);}
        }
        if (bajando == true)
        {
            if (transform.position.y > 8)
            {transform.Translate(Vector3.down * Time.deltaTime *2, Space.World);}
            if (transform.position.x > -7)
            {transform.Translate(Vector3.left * Time.deltaTime *2, Space.World);}
            
        }
    }

    public void ChangeCamera()
    {
        if (isometric == false)
        {
            subiendo = false;
            bajando = true;
            //transform.Rotate(0.0f, 0.0f, 90.0f, Space.World);
            //este es el que anda. llevarlo arriba y ponerle un if y una velocidad.
            isometric = true;
        } else
        {
            bajando = false;
            subiendo = true;
           
            
            isometric = false;
        }
    }
}
