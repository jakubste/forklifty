using System;
using UnityEngine;

public class CameraModes : MonoBehaviour {
    public Camera FirstPersonCamera;
    public Camera ThirdPersonCamera;

    private CameraMode _activeCameraMode;
    private float _lastChange = 0.0f;
    private const float MIN_TIME_BETWEEN_CHANGE = 0.5f;

    internal enum CameraMode {
        FirstPerson,
        ThirdPerson
    }

    // Use this for initialization
    void Start() {
        _activeCameraMode = CameraMode.FirstPerson;
        FirstPersonCamera.enabled = true;
        ThirdPersonCamera.enabled = false;
    }

    // Update is called once per frame
    void Update() {
        ToggleCameraModeOnInput();
    }

    private void ToggleCameraModeOnInput() {
        if (Input.GetKey(KeyCode.C) && Time.time - _lastChange > MIN_TIME_BETWEEN_CHANGE) {
            _lastChange = Time.time;
            Debug.Log("Input!");
            switch (_activeCameraMode) {
                case CameraMode.FirstPerson:
                    _activeCameraMode = CameraMode.ThirdPerson;
                    ChangeCamera(CameraMode.ThirdPerson);
                    break;
                case CameraMode.ThirdPerson:
                    _activeCameraMode = CameraMode.FirstPerson;
                    ChangeCamera(CameraMode.FirstPerson);
                    break;
            }
        }
    }

    private void ChangeCamera(CameraMode mode) {
        switch (mode) {
            case CameraMode.FirstPerson:
                ThirdPersonCamera.enabled = false;
                FirstPersonCamera.enabled = true;
                break;
            case CameraMode.ThirdPerson:
                FirstPersonCamera.enabled = false;
                ThirdPersonCamera.enabled = true;
                break;
        }
    }
}