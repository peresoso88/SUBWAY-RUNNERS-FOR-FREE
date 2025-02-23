using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class drinkFx : MonoBehaviour
{
    [SerializeField] AudioSource DrinkFx;
    public CharacterMovement CharacterMovement;
    private CapsuleCollider CapsuleCollider;
    private void Start()
    {
       CapsuleCollider = GetComponent<CapsuleCollider>();
    }

    void OnTriggerEnter(Collider other)
    {
        DrinkFx.Play();
        StartCoroutine(JumpBoost());
       CapsuleCollider.enabled = false;
        this.gameObject.transform.Translate(new Vector3(0, -50, 0));
    }
    private IEnumerator JumpBoost()
    {
        // Assuming the CharacterMovement script has a public jumpForce variable
        CharacterMovement.jumpForce += 5;
        Debug.Log("WAITING");
        // Wait for 10 seconds
        yield return new WaitForSeconds(5);

        // Revert the jump force
        CharacterMovement.jumpForce -= 5;
        Debug.Log("Ending");
        this.gameObject.SetActive(false);
    }
}
