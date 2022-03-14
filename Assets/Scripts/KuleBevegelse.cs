using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KuleBevegelse : MonoBehaviour
{
    public float speed = -3.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(this.speed * Time.deltaTime, 0.0f, 0.0f);
        if (transform.position.x < -10)
        {
            transform.Translate(20.0f, 0.0f, 0.0f);
        }
    }
}
