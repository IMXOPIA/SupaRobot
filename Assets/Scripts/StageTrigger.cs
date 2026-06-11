using UnityEngine;

public class StageTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerMovement player = other.GetComponent<playerMovement>();

            if (player != null)
            {
                player.SavePlayer();
                Debug.Log("Game Saved!");
            }
        }
    }
}