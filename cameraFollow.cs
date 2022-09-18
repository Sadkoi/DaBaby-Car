using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cameraFollow : MonoBehaviour
{
    public GameObject swivel;
    public GameObject daBaby;

    public float rotationSpeed = 60f;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.J)){
            swivel.transform.localEulerAngles = new Vector3(swivel.transform.localEulerAngles.x, swivel.transform.localEulerAngles.y + (rotationSpeed * Time.deltaTime), swivel.transform.localEulerAngles.z);
        }else{
            if(Input.GetKey(KeyCode.L)){
                swivel.transform.localEulerAngles = new Vector3(swivel.transform.localEulerAngles.x, swivel.transform.localEulerAngles.y + (-rotationSpeed * Time.deltaTime), swivel.transform.localEulerAngles.z);
            }else{
                swivel.transform.rotation = daBaby.transform.rotation;
            }
        }

        swivel.transform.position = daBaby.transform.position;

    }
}
