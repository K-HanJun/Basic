using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int i =0;i < 10; i++)
        {
            Debug.Log($"ÀÎµ¦½º´Â : {i + 1}");
        }

        int counter = 0;

        while(counter <5)
        {
            Debug.Log($"While Counter {counter}");
            counter++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
