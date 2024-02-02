using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        string colliderName = collision.collider.gameObject.name;
        Debug.Log("�arpan obje ad�: " + colliderName);
        if (collision.collider.gameObject.name != "taban")
            Destroy(collision.gameObject);

        Destroy(gameObject);
    }
}
