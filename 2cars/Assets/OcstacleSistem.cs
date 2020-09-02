using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OcstacleSistem : MonoBehaviour
{

    //敵プレハブ
    public GameObject[] notePrefab;
    //時間間隔の最小値
    public float minTime = 1f;
    //時間間隔の最大値
    public float maxTime = 2f;
    //敵生成時間間隔
    private float interval;
    //経過時間
    private float time = 0f;

    private int number;

    public GameObject Damage;

    public static bool DamageFlag;




    // Start is called before the first frame update
    //void Start()
    //{
    //    //時間間隔を決定する
    //    
    //}

    void Start()
    {
        interval = GetRandomTime();
        number = Random.Range(0, notePrefab.Length);
        //Instantiate(notePrefab[number], transform.localPosition, transform.localRotation);

        Damage.SetActive(false);

    }

    void DamageF()
    {

        DamageFlag = false;

        Damage.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {

        if (time > interval) //0秒になれば
        {
            //notePrefabの数だけランダムにする
            number = Random.Range(0, notePrefab.Length); 
            //X座標-10にランダム出現、向きの設定は無し
            Instantiate(notePrefab[number], new Vector3(-5, 0, 175), Quaternion.identity); 
            //次に発生する時間間隔を決定する
            interval = GetRandomTime();
            //経過時間を初期化して再度時間計測を始める
            time = 0f;
        }

        //時間計測
        time += Time.deltaTime;

        if (DamageFlag == true)
        {
            Damage.SetActive(true);

            Invoke("DamageF", 0.1f);

        }

    }

    //ランダムな時間を生成する関数
    private float GetRandomTime()
    {
        return Random.Range(minTime, maxTime);
    }

    //private int RandomPrefabIndex()
    //{
    //    if (notePrefab.Length <= 1)
    //    {
    //        return 0;
    //    }

    //    //int randomIndex = lastPrefabIndex;
    //    //while (randomIndex == lastPrefabIndex)
    //    //{
    //    //    randomIndex = Random.Range(0, note.Length);
    //    //}

    //    //lastPrefabIndex = randomIndex;
    //    //return randomIndex;

    //}
}
