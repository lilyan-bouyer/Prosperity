using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouv : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //convoyer left (1)
    void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("collision");
        float distance = speed * Time.deltaTime;
        transform.Translate(Vector3.right * distance);
    }
}
