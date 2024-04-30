using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiggingController : MonoBehaviour
{
    public Transform leftHandIK;
    public Transform rightHandIk;
    public Transform headIK;

    public Transform leftHandController;
    public Transform rightHandController;
    public Transform hmd;

    public Vector3[] leftOffset;
    public Vector3[] rightOffset;
    public Vector3[] headOffset;

    void FittingHandTransform(Transform ik, Transform controller, bool isLeft) {
        var offset = isLeft ? leftOffset : rightOffset;

        ik.position = controller.TransformPoint(offset[0]);
        ik.rotation = controller.rotation * Quaternion.Euler(offset[1]);
    }
    void FittingBodyTransform(Transform headIK, Transform hmd) {
        this.transform.position = new Vector3(hmd.position.x, hmd.position.y - characterHeight, hmd.position.z);

        float yaw = hmd.eulerAngles.y;
        var targetRotation = new Vector3(this.transform.eulerAngles.x, yaw, this.transform.eulerAngles.z);
        this.transform.rotation = Quaternion.Lerp(this.transform.rotation, Quaternion.Euler(targetRotation), damppingValue);
    }
    void FittingHeadTransform(Transform headIK, Transform hmd) {
        headIK.position = hmd.TransformPoint(headOffset[0]);
        headIK.rotation = hmd.rotation * Quaternion.Euler(headOffset[1]);
    }
    public float damppingValue = 0.1f;
    public float characterHeight = 1.67f;

    private void LateUpdate() {
        FittingHandTransform(leftHandIK, leftHandController, true);
        FittingHandTransform(leftHandIK, leftHandController, false);

        FittingBodyTransform(headIK, hmd);
        FittingHeadTransform(headIK, hmd);
    }
}
