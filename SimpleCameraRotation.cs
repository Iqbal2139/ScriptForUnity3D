using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCameraRotation : MonoBehaviour
{
    [SerializeField]
    GameObject target;

    [SerializeField]
    float rotateSpeed;

    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = target.transform.position - transform.position;        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float horizontal = Input.GetAxis("Mouse X") * rotateSpeed * Time.deltaTime;
        target.transform.Rotate(0, horizontal, 0);

        float desiredAngle = target.transform.eulerAngles.y;
        Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);
        transform.position = target.transform.position - (rotation * offset);

        transform.LookAt(target.transform);
    }
}
