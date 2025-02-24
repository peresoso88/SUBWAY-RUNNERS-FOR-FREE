using UnityEngine;
using System.Collections;
using System.Collections.Generic; 

public class jumpOnceeffect : MonoBehaviour
{
    [SerializeField] AudioSource jumpFx;
  
    public CharacterMovement CharacterMovement;

    void OnTriggerEnter(Collider other)
    {
        jumpFx.Play();
        
        CharacterMovement.rb.AddForce(Vector3.up * 5.5f, ForceMode.Impulse);
        this.gameObject.SetActive(false);

    }
    
}
