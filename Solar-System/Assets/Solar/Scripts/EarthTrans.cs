using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthTrans : MonoBehaviour
{
    private float rotateAngle = 0f;
    private float selfRotateAngle = 0f;
    public float rotateSpeed = 1f;
    public float rotateRadius = 5.0f;
    public float selfRotateSpeed = 100f;
    
    // Update is called once per frame
    void Update()
    {
        float xPosition = rotateRadius * Mathf.Sin(rotateAngle);
        float zPosision = rotateRadius * Mathf.Cos(rotateAngle);

        transform.position = new Vector3(xPosition, 0f, zPosision);

        rotateAngle += rotateSpeed * Time.deltaTime;

        selfRotateAngle = selfRotateSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up, selfRotateAngle);
    }
}
