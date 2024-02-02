using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour
    
{
    float xRot = 0.0f;
    float yRot = 0.0f;
    public float sens = 100.0f;
    public GameObject player,Top;           
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * sens;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * sens;

        xRot -= mouseY;
        xRot += mouseY;
        xRot = Mathf.Clamp(xRot, -10f, 30f);
        yRot = Mathf.Clamp(yRot, -10f, 20f);

        transform.localRotation = Quaternion.Euler(xRot, 0 , 0);
        player.transform.rotation *= Quaternion.Euler(0, mouseX, 0);
        Top.transform.localRotation = Quaternion.Euler(yRot, 0, 0);
        Top.transform.rotation *= Quaternion.Euler(mouseY, 0, 0);

    }
}
