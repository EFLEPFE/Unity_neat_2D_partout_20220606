using UnityEngine;


namespace neat
{
    /// <summary>
    /// �R�A��k
    /// </summary>
    public class APIStatic : MonoBehaviour
    {
        private Vector3 a = new Vector3(1, 1, 1);
        private Vector3 b = new Vector3(22, 22, 22);

        private void Start()
        {
            #region �ǲ�
            // ���o�R�A�ݩ�  get
            // �y�k :
            // ���O.�R�A�ݩʦW��
            print("�H���� : " + Random.value);
            print("PI = " + Mathf.PI);
            print("�L���j = " + Mathf.Infinity);

            // �]�w�R�A�ݩ� set (Read Only ����ϥ�)
            // �y�k :
            // ���O.�R�A�ݩʦW�� ���w ��
            Cursor.visible = false;
            Physics2D.gravity = new Vector2(0, 2f);
            Time.timeScale = 1f;

            // �ϥ��R�A��k
            // �y�k :
            // ���O.�R�A��k�W��(�����޼�)
            float range = Random.Range(15.7f,100.7f);
            print("�H���d�� : " + range);

            int range2 = Random.Range(1, 3);
            print("�H���d�� : " + range2);
            #endregion

            
            print("�۾��ƶq :" +Camera.allCamerasCount);

            print("�ثe���x" +Application.platform);

            Physics.sleepThreshold = 10;
            print("�ίv�{�ɭ�" + Physics.sleepThreshold);

            Time.timeScale = 0.5f;
            print("�ɶ��j�p" + Time.timeScale);

            print("9.999 �h���p���I 4��5�J" + Mathf.Round(9.999f));

            float distance = Vector3.Distance(a, b);
            print("�Z��" + distance);

            Application.OpenURL("https://unity.com/");
        }
        private void Update()
        {
            #region �ǲ�
            int range2 = Random.Range(1, 3);
            print("�H���d�� : " + range2);
            #endregion


            print("���N��" + Input.anyKeyDown);
            
            print("�C���g�L�ɶ�" + Time.timeSinceLevelLoad);

            print("<color=red>���U�ť���" + Input.GetKeyDown(KeyCode.Space) +"</ Color >");

            

            
             

        }
    }
}

    
