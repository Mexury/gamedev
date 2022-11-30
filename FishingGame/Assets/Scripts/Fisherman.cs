using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fisherman : MonoBehaviour
{
    public GameObject bobber;
    public Transform rodConnector;
    Vector2 connectionPoint;
    public LineRenderer lr;
    float lastClicked;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 mousePos = new Vector2(cameraPos.x, cameraPos.y);
        transform.up = mousePos - new Vector2(transform.position.x, transform.position.y);

        if (Input.GetMouseButtonDown(0))
        {
            if (lastClicked + 0.1f < Time.time)
            {
                lastClicked = Time.time;
                connectionPoint = cameraPos;
            }
        }

        lr.SetPosition(0, rodConnector.position);
        lr.SetPosition(1, connectionPoint);
        bobber.transform.position = connectionPoint;
    }
}
