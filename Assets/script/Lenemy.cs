using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lenemy : MonoBehaviour
{
    [Header("Set Enemy Prefab")]
    //敵プレハブ
    public GameObject prefab;
    [Header("Set Interval Min and Max")]
    //時間間隔の最小値
    [Range(1f, 3f)]
    public float minTime = 2f;
    //時間間隔の最大値
    [Range(4f, 8f)]
    public float maxTime = 5f;
    [Header("Set X Position Min and Max")]

    //敵生成時間間隔
    private float interval;
    private float time=0f;

    timer count;
    zanki z;


    // Start is called before the first frame update
    void Start()
    {
        //時間間隔を決定する
        interval = GetRandomTime();
        count = GameObject.Find("time").GetComponent<timer>();
        z = GameObject.Find("fight").GetComponent<zanki>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        //経過時間が生成時間になったとき(生成時間より大きくなったとき)
        if (count.time <= 35f&&count.time>0 && z.getzannki() > 0)
        {
            if (time > interval)
            {
                //enemyをインスタンス化する(生成する)
                GameObject enemy1 = Instantiate(prefab);
                //生成した敵の座標を決定する(現状X=0,Y=10,Z=20の位置に出力)
                enemy1.transform.position = new Vector3(4.2f, 1.4f, -7.5f);
                time = 0f;
                //次に発生する時間間隔を決定する
                interval = GetRandomTime();
            }
        }
    }
    //ランダムな時間を生成する関数
    private float GetRandomTime()
    {
        return Random.Range(minTime, maxTime);
    }
}