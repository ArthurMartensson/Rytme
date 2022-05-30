using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;

public class AvsenderManager : MonoBehaviour
{
    float timer = 0;
    public List<Avsender> avsendere;
    List<List<int>> level;

    void Start()
    {
        level = new List<List<int>>();
        StreamReader inp_stm = new StreamReader("Assets/Levels/level1.txt");
        while (!inp_stm.EndOfStream)
        {
            string inp_ln = inp_stm.ReadLine();
            string[] tick_str = inp_ln.Split(' ');

            List<int> tick_int = new List<int>();
            foreach (string s in tick_str)
            {
                tick_int.Add(int.Parse(s));
            }
            level.Add(tick_int);
        }
        inp_stm.Close();
    }
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 0.5 && this.level.Count > 0)
        {
            foreach (int i in level[0])
            {
                this.avsendere[i].Send();
            }
            this.level.RemoveAt(0);
            timer -= 0.5f;
        }
    }
}
