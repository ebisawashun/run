using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject target;
    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        pos = Camera.main.gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPos = target.transform.position;

        if(target.transform.position.x < 0)
        {
            cameraPos.x = 0;
        }

        if(transform.position.y < -1.2)
        {
            cameraPos.y = 0;
        }

        if(target.transform.position.y > -1.2)
        {
            cameraPos.y = target.transform.position.y;
        }

        cameraPos.z = -10;
        Camera.main.gameObject.transform.position = cameraPos;
    }
}
