using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchAndRotate : MonoBehaviour
{
    bool rotate = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.rotate)
        {
            this.gameObject.transform.Rotate(new Vector3(0f, 1f, 0f));
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision detected!");
        this.rotate = true;
    }

}
