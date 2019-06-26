using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shifting : MonoBehaviour {
    [SerializeField] private Vector3 gravity;
    [SerializeField] private float smooth = 1.0f;
    [SerializeField] private float time = 0.5f;
    [SerializeField] private Vector3 targetAngles;

    void Update () {

        gravity = Physics.gravity;
        if (Input.GetButtonDown("Shift"))
        {
            Physics.gravity = -gravity;
            targetAngles = transform.eulerAngles + 180f * Vector3.up; // what the new angles should be

        }

        if (targetAngles != transform.eulerAngles)
        {
            transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, targetAngles, smooth * Time.deltaTime); // lerp to new angles
        }
    }
}
