using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishGroundCheck : MonoBehaviour
{
    public GameObject winPanel;
    public GameObject controlPanelRight;
    public GameObject controlPanelLeft;
    public string level; //it must be Level1, Level2...

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log(collision.gameObject.name);
            winPanel.SetActive(true);
            if (TouchLayoutManager.getLayout() == 0)
            {
                controlPanelLeft.SetActive(false);
            }
            else
            {
                controlPanelRight.SetActive(false);
            }
            CheckPoint.UnsavePlayer(level);
            Time.timeScale = 0f;
        }
    }
}
