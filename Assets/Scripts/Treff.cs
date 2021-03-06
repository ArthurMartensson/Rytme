using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treff : MonoBehaviour
{
    public List<Transform> kuler;
    public ScoreManager scoremanager;
    public KeyCode avtrekker;

    public void Start()
    {
        kuler = new List<Transform>();
    }

    void Update()
    {
        if (Input.GetKeyDown(avtrekker) && kuler.FindAll(s => s != null).Count > 0)
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
            if (Vector3.Distance(transform.position, nærmeste.position) < 0.2)
            {
                Destroy(nærmeste.gameObject);
                scoremanager.UpdateScore(3);
            }
            else if (Vector3.Distance(transform.position, nærmeste.position) < 1)
            {
                Destroy(nærmeste.gameObject);
                scoremanager.UpdateScore(1);
            }
            else
            {
                scoremanager.UpdateScore(-1);
            }
        }
    }
}
