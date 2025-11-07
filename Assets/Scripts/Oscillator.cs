using UnityEngine;

public class Oscillator : MonoBehaviour
{
  
    [SerializeField] private float frequency = 1.2f;
    [SerializeField] private float amplitude = 3f;
    [SerializeField] private bool useLocalSpace = false;

    private Vector3 startPos;




    void Start()
    {
        startPos = useLocalSpace? transform.localPosition : transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float x = startPos.x + amplitude * Mathf.Sin(2f* Mathf.PI * frequency * Time.time);

       if(useLocalSpace)
        {
            transform.localPosition = new Vector3(x, startPos.y, startPos.z);
        }
        else
        {
            transform.position = new Vector3(x, startPos.y, startPos.z);
           
        }


    }
}   
