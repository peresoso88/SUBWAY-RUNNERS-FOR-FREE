using UnityEngine;

public class ItemsRot : MonoBehaviour
{
    public float RotationSpeed = 100f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0 * Time.deltaTime, RotationSpeed);
    }
}
