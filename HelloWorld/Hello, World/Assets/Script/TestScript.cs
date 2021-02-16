using System.Numerics;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = UnityEngine.Debug;
using Vector3 = UnityEngine.Vector3;

public class TestScript : MonoBehaviour
{
    private BoxCollider box;
    private GameObject g;
    private Light light;
    private Transform lightTrans;

    // Start is called before the first frame update
    // この設計図がゲーム内で実体化＋有効の両方を満たす時Unity側から1回だけ呼ばれます。
    void Start()
    {
        box = GetComponent<BoxCollider>();

        g = GameObject.Find("Directional Light");
        lightTrans = g.GetComponent<Transform>();
        light = g.GetComponent<Light>();
    }

    // Update is called once per frame
    // 有効な時にゲーム中毎フレームUnity側から呼ばれます。
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 1));
        lightTrans.Rotate(new Vector3(1, 0, 0));
    }
}
