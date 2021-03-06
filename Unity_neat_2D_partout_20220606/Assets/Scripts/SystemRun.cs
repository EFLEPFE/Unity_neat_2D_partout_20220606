
using UnityEngine;    //引用 Unity 影擎 命名空間(API)

namespace neat
{
    // C# 從藍圖變成實體物件
    // 1.場景上的遊戲物件 Game Object 灰色線條方塊
    // 2.將此腳本掛在該物件變成元件

    /// <summary>
    /// 跑步系統
    /// </summary>

    public class SystemRun : MonoBehaviour
    {
        #region 資料:保存資料
        // 欄位 Field :保存資料
        // 語法 :
        //修飾詞 欄位資料類型 欄位自訂名稱 (指定 預設值)

        //修飾詞 
        //公開 : 顯示在面板，允許其他類別存取          public 
        //私人 : 不顯示在面板，不允許其他類別存取       private (封裝) 

        //SerializeField Field 序列化欄位 : 將私人欄位顯示
        //Header 標題 : 可以使用中文
        //Tooltip 提示 : 可以使用中文
        //Range 範圍 : 僅限於數值類型資料 int ,float ,byte ,long

        [SerializeField, Header("跑步速度"), Tooltip("5這是跑步速度"), Range(0,100)]
        private float speedRun = 10f;
        private float maxspeedRun = 100;
        

        private Animator ani;
        private Rigidbody2D rig;



        #endregion

        #region 功能:實作該系統複雜方法

        // 方法 Method
        // 語法 :
        //修飾詞 傳回資料類型  方法名稱(參數) { 程式 }
        /// <summary>
        /// 跑步功能
        /// </summary>
        private void Run()
        {
            //print("跑步中!!!!!!");
            rig.velocity = new Vector2(speedRun, rig.velocity.y);

            
        }

        #endregion

        #region 事件:城市入口
        //喚醒事件 : 開始事件前執行一次，取得元件等等
        private void Awake()
        {
            // ani 指定 忍者龜身上的 Animator
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }


        // 開始事件 : 播放遊戲時執行一次
        // 初始化設定 ，例如 : 英雄聯盟 500 塊 . 生命初始化 3 條 ...
        private void Start()
        {
            //print("哈囉  請不要偷看!!!");            
        }

       


        // 更新事件 : 每秒執行約六十次 60FPS Frame
        private void Update()
        {
            //print("<color=yellow>更新事件執行中!!!</color>");

            //呼叫方法：方法名稱(對應的引數);
            Run();

        }
        #endregion

        private void OnEnable()
        {
            
        }

        private void OnDisable()
        {
            // 加速度歸零
            rig.velocity = Vector3.zero;
        }
    }

}



