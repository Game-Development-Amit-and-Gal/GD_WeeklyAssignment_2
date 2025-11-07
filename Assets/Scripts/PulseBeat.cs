using Unity.VisualScripting;
using UnityEngine;

public class PulseBeat : MonoBehaviour
{
    [SerializeField] private float pulseSpeed = 1f;
    private float pi = Mathf.PI;
    [SerializeField] private float amplitude1 = 1f;
    [SerializeField] private float amplitude2 = 0.3f;
    [SerializeField] private float amplitude3 = 0.2f;
    [SerializeField] private float scaleMultiplier = 1.3f;
    [SerializeField] private float baseScale = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Foruier Approximation of a square wave
        float time = Time.time * pulseSpeed;
        float beat = 0f;
        
        float [] amplitudes = { amplitude1, amplitude2, amplitude3 };
        int index = 0;

        for (float i = 2f; i <= 6f; i+= 2f)
        {
            beat += (float) (amplitudes[index] * (Mathf.Sin(i * pi * time)));
            index++;
        }

        beat = Mathf.Max(0f, beat); // avoid negative scaling

        transform.localScale = Vector3.one * (baseScale + scaleMultiplier * beat);
    }
}
