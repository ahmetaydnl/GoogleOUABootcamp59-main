using UnityEngine;

public class ExampleDamageSource : MonoBehaviour
{
    public float damageAmount = 20f; // Bu deðiþken artýk kullanýlmýyor, ama burada kalsýn.

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("NPC"))
        {
            // NPC'yi devre dýþý býrak
            collision.collider.gameObject.SetActive(false);
        }
    }
}
