using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMover : MonoBehaviour
{
    private Transform tf;

    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        tf = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //move up if the player presses up
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) // "||" means or 
        { 
            //only works if shift is held down
        }
        else
        {
            //only works if shift is not held down
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            tf.position = tf.position + Vector3.up * Time.deltaTime * speed;
        }

    }
}
