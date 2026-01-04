using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //AddScore(1);
            ScoreManager.Instance.AddScore(100);
            GetComponent<Collider2D>().enabled = false;
        }
    }
}