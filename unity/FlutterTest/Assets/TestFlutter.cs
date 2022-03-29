using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestFlutter : MonoBehaviour
{
    
    float _speed=10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
         transform.Rotate(0,_speed * Time.fixedDeltaTime,0);
    }

    public void Zoom(string value)
    {
        if(float.TryParse(value, out var v))
        {
            _speed = v;
        }
    }
}
