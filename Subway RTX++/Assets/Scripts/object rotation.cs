using UnityEngine;

public class objectrotation : MonoBehaviour
{
    public float RotationSpeed = 25f;

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(0, RotationSpeed * Time.deltaTime, 0);
    }
}
