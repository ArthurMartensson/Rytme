using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treff : MonoBehaviour
{
    public List<Transform> kuler;
    public ScoreManager scoremanager;

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Transform nærmeste = kuler[0];
            foreach (Transform kule in kuler)
            {
                if (Vector3.Distance(transform.position, kule.position)
                    < Vector3.Distance(transform.position, nærmeste.position))
                {
                    nærmeste = kule;
                }
            }
            if (Vector3.Distance(transform.position, nærmeste.position) < 1)
            {
                nærmeste.Translate(20, 0, 0);
                scoremanager.UpdateScore(1);
            }
        }
    }
}
