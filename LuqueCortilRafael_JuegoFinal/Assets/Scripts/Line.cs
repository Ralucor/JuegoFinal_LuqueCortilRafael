using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Line : MonoBehaviour
{
    public LineRenderer line;
    public GameObject newLine;
   
    public float minimumVertexDistance = 0.1f;

    public Vector3 GetWorldCoordinate(Vector3 mousePosition)
    {
        Vector3 mousePos = new Vector3(mousePosition.x, mousePosition.y, 1);
        return Camera.main.ScreenToWorldPoint(mousePos);
    }

    void Start()
    {
        // set the color of the line
        line.startColor = Color.red;
        line.endColor = Color.red;

        // set width of the renderer
        line.startWidth = 0.3f;
        line.endWidth = 0.3f;
        line.positionCount = 0;
    }


    void Update()
    {
        if ((Input.GetMouseButtonDown(0)) && Line.positionCount == 0)

        {
            Vector3 mousePos = GetWorldCoordinate(Input.mousePosition);
            line.SetPosition(0, mousePos);
            line.positionCount = line.positionCount + 2;
            
               
        }

        
        if (Input.GetMouseButtonDown(0) && line.positionCount == 2)

        {
            Vector3 mousePos = GetWorldCoordinate(Input.mousePosition);
            line.SetPosition(1, mousePos);
            Instantiate(newLine, transform.position, Quaternion.Euler(0, 0, 0));
            GetComponent<DrawLine_2PT>().enabled = false;

        }

    }
}
