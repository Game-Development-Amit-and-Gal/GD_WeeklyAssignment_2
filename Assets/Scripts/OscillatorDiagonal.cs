using UnityEngine;

public class OscillatorDiagonal : MonoBehaviour
{
    [SerializeField] private float frequency = 1.2f;
    [SerializeField] private float amplitude = 3f;
    [SerializeField] private bool useLocalSpace = false;

    private Vector3 startPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = useLocalSpace ? transform.localPosition : transform.position;
    }

    void Update()
    {
        float y = startPos.x + amplitude * Mathf.Cos(2f * Mathf.PI * frequency * Time.time);
        

        if (useLocalSpace)
        {
            transform.localPosition = new Vector3(y, y, startPos.z);
        }
        else
        {
            transform.position = new Vector3(y, y, startPos.z);

        }
    }
}
