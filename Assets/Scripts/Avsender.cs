using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avsender : MonoBehaviour
{
    float timer = 0;
    public GameObject kule;
    public Treff treff;
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 0.5)
        {
            GameObject k = Instantiate(kule, transform);
            treff.kuler.Add(k.transform);
            timer = timer - 0.5f;
        }
    }
}
