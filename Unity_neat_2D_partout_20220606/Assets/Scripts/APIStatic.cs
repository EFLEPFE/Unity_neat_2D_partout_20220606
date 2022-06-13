using UnityEngine;


namespace neat
{
    /// <summary>
    /// 靜態方法
    /// </summary>
    public class APIStatic : MonoBehaviour
    {
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

            int count = Camera.allCameras.Length;
            print("相機數量 :" + count);

            if (Application.isEditor)
            {
                print("大概是");
            }



        }
        private void Update()
        {
            #region 學習
            int range2 = Random.Range(1, 3);
            print("隨機範圍 : " + range2);
            #endregion
            if (Input.anyKey) 
            {
                print("任意按");
            }
            Time.timeScale = 1f;
            
             

        }
    }
}

    
