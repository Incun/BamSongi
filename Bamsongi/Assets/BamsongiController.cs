using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongiController : MonoBehaviour
{
    
    float delta = 0;

    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    void OnCollisionEnter(Collision Other)
    {
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<ParticleSystem>().Play();
    }

    void Start ()
    {
        //Shoot(new Vector3(0, 200, 2000));
    }
	
	void Update ()
    {
        this.delta += Time.deltaTime;
        if (delta > 2)
        {
            Destroy(gameObject);
        }
    }
}
