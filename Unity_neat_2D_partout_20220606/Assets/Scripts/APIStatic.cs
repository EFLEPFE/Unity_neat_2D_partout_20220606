using UnityEngine;


namespace neat
{
    /// <summary>
    /// 靜態方法
    /// </summary>
    public class APIStatic : MonoBehaviour
    {
        private Vector3 a = new Vector3(1, 1, 1);
        private Vector3 b = new Vector3(22, 22, 22);

        private void Start()
        {
            #region 學習
            // 取得靜態屬性  get
            // 語法 :
            // 類別.靜態屬性名稱
            print("隨機值 : " + Random.value);
            print("PI = " + Mathf.PI);
            print("無限大 = " + Mathf.Infinity);

            // 設定靜態屬性 set (Read Only 不能使用)
            // 語法 :
            // 類別.靜態屬性名稱 指定 值
            Cursor.visible = false;
            Physics2D.gravity = new Vector2(0, 2f);
            Time.timeScale = 1f;

            // 使用靜態方法
            // 語法 :
            // 類別.靜態方法名稱(對應引數)
            float range = Random.Range(15.7f,100.7f);
            print("隨機範圍 : " + range);

            int range2 = Random.Range(1, 3);
            print("隨機範圍 : " + range2);
            #endregion

            
            print("相機數量 :" +Camera.allCamerasCount);

            print("目前平台" +Application.platform);

            Physics.sleepThreshold = 10;
            print("睡眠臨界值" + Physics.sleepThreshold);

            Time.timeScale = 0.5f;
            print("時間大小" + Time.timeScale);

            print("9.999 去掉小數點 4捨5入" + Mathf.Round(9.999f));

            float distance = Vector3.Distance(a, b);
            print("距離" + distance);

            Application.OpenURL("https://unity.com/");
        }
        private void Update()
        {
            #region 學習
            int range2 = Random.Range(1, 3);
            print("隨機範圍 : " + range2);
            #endregion


            print("任意案" + Input.anyKeyDown);
            
            print("遊戲經過時間" + Time.timeSinceLevelLoad);

            print("<color=red>按下空白鍵" + Input.GetKeyDown(KeyCode.Space) +"</ Color >");

            

            
             

        }
    }
}

    
