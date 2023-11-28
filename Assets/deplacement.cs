using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deplacement : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //float distance = speed * Time.deltaTime;
        //transform.Translate(Vector3.up * distance);
    }
    void OnTriggerStay2D(Collider2D other)
    {
        float distance = speed * Time.deltaTime;
        //getcomponent<transform>
        //if (Transform.GetLocalRotation)
        Debug.Log("hello");
        other.GetComponentInParent<Transform>().Translate(Vector3.up * distance);
    }
}
