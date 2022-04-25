using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvsenderManager : MonoBehaviour
{
    float timer = 0;
    public List<Avsender> avsendere;
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 0.5)
        {
            avsendere[0].Send();
            timer -= 0.5f;
        }
    }
}
