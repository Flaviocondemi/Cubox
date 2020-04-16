using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheckPoint : MonoBehaviour
{
    public string level;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Checkpoint"))
        {
            if (CheckPoint.isSaved(level) == CheckPoint.STATE_UNSAVED)
            {
                SoundManager.playSound("CheckPoint");
                CheckPoint.SavePlayer(level);
            }

        }
    }
}
