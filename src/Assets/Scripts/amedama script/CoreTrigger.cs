using System;
using UnityEngine;

public class CoreTrigger : MonoBehaviour
{

    void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag == "Bomb")
        {

            Rigidbody[] rigidbodies = GetComponentsInChildren<Rigidbody>() ;
            
            foreach (Rigidbody r in rigidbodies)
            {

                r.tag = "enemies";

                if (r.gameObject == gameObject) { continue; }

                //r.isKinematic = false;

            }

            Transform ParentRigidbody = transform.root;
            ParentRigidbody.tag = "enemies";

        }
    }
}
