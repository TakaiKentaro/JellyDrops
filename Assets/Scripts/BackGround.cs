using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    public GameObject[] BirdPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        IEnumerator DropBirds(int count)
        {
            for (int i = 0; i < count; i++)
            {
                // ランダムで出現位置を作成
                Vector2 pos = new Vector2(Random.Range(-3.5f, 3.5f), 8f);
                // ランダムで鳥を出現させてIDを格納
                int id = Random.Range(0, BirdPrefabs.Length);
                // 鳥を発生させる
                GameObject bird = (GameObject)Instantiate(BirdPrefabs[id],
                    pos,
                    Quaternion.AngleAxis(Random.Range(-40, 40), Vector3.forward));
                // 作成した鳥の名前を変更します
                bird.name = "Bird" + id;
                // 0.05秒待って次の処理へ
                yield return new WaitForSeconds(0.1f);
            }
        }
        StartCoroutine(DropBirds(1000));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
