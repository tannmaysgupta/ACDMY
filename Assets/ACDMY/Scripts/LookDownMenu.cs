using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookDownMenu : MonoBehaviour
{

    public Transform myCamera;

    public float toggleAngle = 40.0f;

    public bool showMenu;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(myCamera.eulerAngles.x >= toggleAngle && myCamera.eulerAngles.x < 90.0f)
        {
            showMenu = true;
        }
        else
        {
            showMenu = false;
        }

        if (showMenu)
        {
            Debug.Log("Showing Menu");
        }
    }
}
