using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Forward axis movement
        float horInput = Input.GetAxis("Vertical");
        float verInput = Input.GetAxis("Horizontal");
        float mouseInput = Input.GetAxis("Mouse X");

        transform.Translate(Vector3.forward * horInput * speed * Time.deltaTime);
        transform.Translate(Vector3.right * verInput * speed * Time.deltaTime);
        transform.Rotate(0, mouseInput, 0, Space.Self);
    }
}
