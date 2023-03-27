using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{

    Camera cameraNew;

    public float power = 0.7f;
    public float duration = 0.7f;
    public Transform cameraMain;
    public float slowDownAmount = 1.0f;
    public bool shouldShake = false;

    Vector3 startPosition;
    float initialDuration;
    // Start is called before the first frame update
    void Start()
    {
        cameraNew = GetComponent<Camera>();
        cameraMain = Camera.main.transform;
        startPosition = cameraMain.localPosition;
        initialDuration = duration;
    }

    // Update is called once per frame
    void Update()
    {




        if (shouldShake)
        {
            if (duration > 0)
            {
                GetComponent<Camera>().transform.localPosition = startPosition + Random.insideUnitSphere * power;
                duration -= Time.deltaTime * slowDownAmount;
            }
            else
            {
                shouldShake = false;
                duration = initialDuration;
                GetComponent<Camera>().transform.localPosition = startPosition;
            }
        }
    }
}
