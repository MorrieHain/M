using UnityEngine;

public class ballmover : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("nihao");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        Debug.DrawLine(Vector3.zero, Vector3.one, Color.blue);
    }

}
