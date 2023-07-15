using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skupljanjevoca : MonoBehaviour
{
       private int lubenica = 0;

    [SerializeField] private Text lubenicaText;

    [SerializeField] private AudioSource collectionSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("lubenica"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            lubenica++;
            lubenicaText.text = "Lubenica: " + lubenica;
        }
    }
}
