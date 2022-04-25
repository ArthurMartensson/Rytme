using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treff : MonoBehaviour
{
    public List<Transform> kuler;
    public ScoreManager scoremanager;

    public void Start()
    {
        kuler = new List<Transform>();
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            kuler.RemoveAll(s => s == null);
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
                Destroy(nærmeste.gameObject);
                scoremanager.UpdateScore(1);
            }
        }
    }
}
