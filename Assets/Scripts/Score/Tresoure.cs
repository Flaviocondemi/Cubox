using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tresoure : MonoBehaviour
{
    private Transform player;
    private Vector2 target;
    public float stopDistance;

    public TextMeshProUGUI coinText;

    private SpriteRenderer sr;
    public Sprite sprite;

    private Sprite spriteTmp;

    public GameObject particleEffect;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        sr = GetComponent<SpriteRenderer>();
        spriteTmp = sr.sprite;
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            target = new Vector2(player.position.x, player.position.y);
            if (Vector2.Distance(transform.position, target) < stopDistance)
            {
                sr.sprite = sprite;
                particleEffect.SetActive(true);
            }
            else
            {
                particleEffect.SetActive(false);
                sr.sprite = spriteTmp;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
            coinEarn();
        }
    }

    private void coinEarn()
    {
        SoundManager.playSound("Coin");
        ScoreCoin.setMoney();
        coinText.SetText(ScoreCoin.getMoney());
    }
}
