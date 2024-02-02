using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazer : MonoBehaviour
{
    public GameObject mermiObj;
    public Transform atesNoktasi;
    public float mermiHizi= 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButtonDown ("Fire1"))
        {
            AtesEt();
        }
    }
    private void AtesEt()
    {
        GameObject mermi = Instantiate(mermiObj, atesNoktasi.position, atesNoktasi.rotation);
        Rigidbody mermiRigidbody = mermi.GetComponent<Rigidbody>();

        mermiRigidbody.velocity = atesNoktasi.forward * mermiHizi;
    }
}
