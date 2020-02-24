using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    public Transform[] movementPoints;
    
    public int playerSpeed;
    public Vector3 pointPos;

    public GameObject movPoint;

    // Start is called before the first frame update
    void Start()
    {
        movementPoints = new Transform[transform.childCount];
        int i = 0;

        foreach (Transform t in transform)
        {
            movementPoints[i++] = t;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            transform.position = transform.position + pointPos * playerSpeed * Time.deltaTime;
        }
    }

    //public void findPos(movPoint)
    //{
      //  pointPos = gameObject.transform.position;
        
    //}
}
