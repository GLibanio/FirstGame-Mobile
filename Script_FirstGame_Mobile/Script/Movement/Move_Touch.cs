using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Touch : MonoBehaviour
{
    public FixedTouch FixedTouch;
    public FirstPerson_Cam Cam;

    // Update is called once per frame
    void Update()
    {
        var fps = GetComponent<Player>();

        Cam.LookAxis = FixedTouch.TouchDist;
        
        
    }
}
