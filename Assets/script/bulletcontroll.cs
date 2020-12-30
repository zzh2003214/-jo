using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class bulletcontroll : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float speed = 30.0f;
    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > 11)
        {
            Destroy(gameObject);
        }
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
}
