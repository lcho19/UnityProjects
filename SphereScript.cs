using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    Vector3 temp;
    Vector3 Pos;
    Vector3 MyGameObjectPosition;
    // Start is called before the first frame update
    void Start()
    {
        MyGameObjectPosition = GameObject.FindGameObjectWithTag("Moving").transform.position;
        Debug.Log("The position of the Quad is: " + MyGameObjectPosition);
        if (MyGameObjectPosition.x == 1)
        {
            temp = transform.localScale;
            temp.x = 3;
            transform.localScale = temp;
            Debug.Log("The Sphere now scales");
        }
    }

// Update is called once per frame
void Update()
    {
    
    }
}
