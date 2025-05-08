using UnityEngine;

public class LoseGame : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            Time.timeScale=0;
        }
    }
}
