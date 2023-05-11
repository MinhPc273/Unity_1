using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class line : MonoBehaviour
{
    public float moveSpeed;
    float xDrirection;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xDrirection = Input.GetAxisRaw("Horizontal");
        float moveStep = moveSpeed * xDrirection * Time.deltaTime;
        if((transform.position.x <= -8 && xDrirection<0)|| (transform.position.x >=8 && xDrirection>0)) return;
        transform.position += new Vector3(moveStep,0,0);
    }

}
