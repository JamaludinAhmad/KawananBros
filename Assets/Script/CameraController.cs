using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform cameraPos;

    private void LateUpdate() {
        this.transform.position = new Vector3(cameraPos.position.x, cameraPos.position.y, -10);
    }
}
