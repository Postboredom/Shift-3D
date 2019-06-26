using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shifting : MonoBehaviour {
    [SerializeField] private Vector3 gravity;
    [SerializeField] private float smooth = 10.0f;
    [SerializeField] private float time = 0.5f;
    [SerializeField] private Vector3 targetAngles;
    private void Start()
    {
        targetAngles = transform.position;
    }
    void Update () {

        gravity = Physics.gravity;
        if (Input.GetButtonDown("Shift"))
        {
            Physics.gravity = -gravity;
            targetAngles = transform.eulerAngles + 180f * Vector3.forward; // what the new angles should be

        }
            transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, targetAngles, smooth * Time.deltaTime); // lerp to new angles
        
    }
}
