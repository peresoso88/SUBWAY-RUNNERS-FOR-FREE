using UnityEngine;
using System.Collections;
using System.Collections.Generic; 

public class jumpOnceeffect : MonoBehaviour
{
    [SerializeField] AudioSource jumpFx;
    public float jumpForce = 15f;
    public CharacterMovement CharacterMovement;

    void OnTriggerEnter(Collider other)
    {
        jumpFx.Play();
        
        CharacterMovement.rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        this.gameObject.SetActive(false);

    }
    
}
