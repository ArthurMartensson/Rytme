using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KuleBevegelse : MonoBehaviour
{
    public float speed = -3.0f;
    public ScoreManager scoremanager;
    // Start is called before the first frame update
    void Start()
    {
        this.scoremanager = GameObject.Find("ScoreManager")
            .GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(this.speed * Time.deltaTime, 0.0f, 0.0f);
        if (transform.position.x < -10)
        {
            Destroy(gameObject);
            scoremanager.UpdateScore(-1);
        }
    }
}
