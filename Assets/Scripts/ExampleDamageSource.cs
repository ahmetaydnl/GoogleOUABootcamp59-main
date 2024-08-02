using UnityEngine;

public class ExampleDamageSource : MonoBehaviour
{
    public float damageAmount = 20f; // Bu de�i�ken art�k kullan�lm�yor, ama burada kals�n.

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("NPC"))
        {
            // NPC'yi devre d��� b�rak
            collision.collider.gameObject.SetActive(false);
        }
    }
}
