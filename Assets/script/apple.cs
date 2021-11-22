using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apple : MonoBehaviour
{
    [Header("Set Enemy Prefab")]
    //敵プレハブ
    public GameObject prefab;
    [Header("Set Interval Min and Max")]
    //時間間隔の最小値
    [Range(1f, 3f)]
    public float minTime = 1f;
    //時間間隔の最大値
    [Range(4f, 10f)]
    public float maxTime = 4f;
    [Header("Set X Position Min and Max")]

    //敵生成時間間隔
    private float interval1;
    //経過時間
    private float time1 = 0f;
    private float interval2 = 1f;

    private float counttime = 0f;
    private float position;

    timer t;
    zanki z;

    // Start is called before the first frame update
    void Start()
    {
        //時間間隔を決定する
        interval1 = GetRandomTime();
        t = GameObject.Find("time").GetComponent<timer>();
        z = GameObject.Find("fight").GetComponent<zanki>();
    }

    // Update is called once per frame
    void Update()
    {
        //時間計測
        time1 += Time.deltaTime;
        if (counttime >= 0 && counttime <= 61)
        {
            counttime += Time.deltaTime;
        }

        position = Random.Range(2f, -4f);


        if (t.time > 0 && z.getzannki() > 0)
        {
            //経過時間が生成時間になったとき(生成時間より大きくなったとき)
            if (time1 > interval1)
            {
                //enemyをインスタンス化する(生成する)
                GameObject apple1 = Instantiate(prefab);
                //生成した敵の座標を決定する(現状X=0,Y=10,Z=20の位置に出力)
                apple1.transform.position = new Vector3(-4.4f, 7.4f, position);
                /*
                rb1 = apple1.GetComponent<Rigidbody>();
                rb1.drag = Random.Range(2f, 6f);
                */
                //経過時間を初期化して再度時間計測を始める
                time1 = 0f;
                //次に発生する時間間隔を決定する
                interval1 = GetRandomTime();
            }

            if (counttime >= 30f && z.getzannki() > 0)
            {
                if (counttime > interval2)
                {
                    //enemyをインスタンス化する(生成する)
                    GameObject apple2 = Instantiate(prefab);
                    //生成した敵の座標を決定する(現状X=0,Y=10,Z=20の位置に出力)
                    apple2.transform.position = new Vector3(-4.4f, 7.4f, position);
                    /*
                     rb2 = apple2.GetComponent<Rigidbody>();
                                        rb2.drag = Random.Range(2f, 6f);
                                        */
                    //経過時間を初期化して再度時間計測を始める
                    counttime = 30f;
                    //次に発生する時間間隔を決定する
                    interval2 = Random.Range(31f, 34f);

                }
            }
        }
    }
    //ランダムな時間を生成する関数
    private float GetRandomTime()
    {
        return Random.Range(minTime, maxTime);
    }

}