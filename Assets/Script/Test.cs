using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int i =0;i < 10; i++)
        {
            Debug.Log($"{i}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
