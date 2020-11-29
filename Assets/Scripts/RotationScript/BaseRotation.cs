using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseRotation : MonoBehaviour
{
    public float MaxAngle = 80;
    public float MinAngle = -80;
    public void RotateUpDown(float axis)
    {
        transform.RotateAround(transform.position, transform.right, -axis * Time.deltaTime);
        #region LimitRange on X
        // get relative range +/-
        float relRange = (MaxAngle - -MinAngle) / 2f;

        // calculate offset
        float offset = MaxAngle - relRange;

        // convert to a relative value
        Vector3 angles = transform.eulerAngles;
        float x = ((angles.x + 540) % 360) - 180 - offset;

        // if outside range
        if (Mathf.Abs(x) > relRange)
        {
            angles.x = relRange * Mathf.Sign(x) + offset;
            transform.eulerAngles = angles;
        }
        #endregion
    }

    //rotate the camera rigt and left (y rotation)
    public void RotateRightLeft(float axis)
    {
        transform.RotateAround(transform.position, Vector3.up, -axis * Time.deltaTime);
    }
}
