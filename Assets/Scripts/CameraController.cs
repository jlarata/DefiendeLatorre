using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public bool isometric;
    public bool subiendo;
    public bool bajando;
    public bool rotandoClock;
    public bool rotandoContClock;

    public Vector3 currentEulerAngles;
    public Quaternion currentRotation;

    // Start is called before the first frame update
    void Start()
    {
        isometric = false;
        subiendo = false;
        bajando = false;

        currentEulerAngles = currentRotation.eulerAngles;

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C)) //&& bajando == false && subiendo == false)
        {
            ChangeCamera();
        }

        if (subiendo == true)
        {

            
                if (currentEulerAngles.z < 0)
                {
                    transform.Rotate(0.0f, 0.0f, 1.5f, Space.Self);
                    currentEulerAngles += new Vector3(0f, 0f, 1.5f);
                }
                if (currentEulerAngles.x < 0)
                {
                    transform.Rotate(0.4f, -1f, 0f, Space.Self);
                    currentEulerAngles += new Vector3(1f, 0f, 0f);
                }
            

                    if (transform.position.y < 14)
                    {transform.Translate(Vector3.up * Time.deltaTime *3, Space.World);}
                    if (transform.position.x < -0.5f)
                    {transform.Translate(Vector3.right * Time.deltaTime * 18, Space.World);}
                    /* else 
                    {
                        subiendo = false;
                    } */
                    
            }
        

            
        if (bajando == true)
        {
            if (transform.position.y > 8)
            {transform.Translate(Vector3.down * Time.deltaTime *3, Space.World);}
            if (transform.position.x > -18)
            {transform.Translate(Vector3.left * Time.deltaTime * 18, Space.World);}
             /* else
            {
                
                bajando = false;
            } */ 
            if (currentEulerAngles.x > -60)
            {
                transform.Rotate(-0.4f, 1f, 0f, Space.Self);
                currentEulerAngles += new Vector3(-1f, 0f, 0f);
            } 
            if (currentEulerAngles.z > -90)
            {
                transform.Rotate(0.0f, 0.0f, -1.5f, Space.Self);
                currentEulerAngles += new Vector3(0f, 0f, -1.5f);
            }       
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
            rotandoContClock = true;
            subiendo = true;
           
            
            isometric = false;
        }
    }
}
