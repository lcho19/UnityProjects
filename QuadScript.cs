using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadScript : MonoBehaviour
{
    int i = 0;
    Vector3 originalPos;
    Vector3 newPos;
    // Start is called before the first frame update
    void Start()
    {
        originalPos = transform.position;
        newPos = transform.position;
        Debug.Log("Getting the original position of Quad");
        while (i < 6)
        {
            newPos.x = 1;
            newPos.y = 1;
            i++;
            Debug.Log("The New Position of the Quad is calculated");
        }
        transform.position = newPos;
        Debug.Log ("The Original position of the Quad: " + originalPos);
        Debug.Log ("The new position of the Quad: " + newPos);
    }
        

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
