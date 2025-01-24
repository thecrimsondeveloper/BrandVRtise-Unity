using UnityEngine;

public class PulseObject : MonoBehaviour
{
    public Transform target;
    public Vector3 pulseScale = new Vector3(1.2f, 1.2f, 1.2f);
    public float totalPulseTime = 0.5f;
    public AnimationCurve pulseCurve = AnimationCurve.EaseInOut(0.0f, 0.0f, 1.0f, 1.0f);

    Vector3 startingScale;

    Vector3 targetScale;

    float pulseTimeLeft = 0.0f;
    

    void Start()
    {
        startingScale = transform.localScale;
    }

    void Update()
    {   

        if (pulseTimeLeft > 0.0f)
        {
            pulseTimeLeft -= Time.deltaTime;
            if (pulseTimeLeft <= 0.0f)
            {
                transform.localScale = startingScale;
            }
            else
            {
                float t = 1.0f - Mathf.Clamp01(pulseTimeLeft / totalPulseTime);
                t = pulseCurve.Evaluate(t);
                transform.localScale = Vector3.Lerp(startingScale, targetScale, t);
            }
        }

    }


    public void Pulse()
    {
        if (pulseTimeLeft <= 0.0f)
        {
            targetScale = Vector3.Scale(startingScale, pulseScale);
            pulseTimeLeft = totalPulseTime;
        }
    }
}
