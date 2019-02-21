using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RectangleScript : MonoBehaviour
{
    Vector3 tempRotation;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(speed, speed, 0f);
        Debug.Log("The Rectangle now Rotates");
    }
}
