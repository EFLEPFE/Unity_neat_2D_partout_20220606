using UnityEngine;


namespace neat
{
    /// <summary>
    /// �R�A��k
    /// </summary>
    public class APIStatic : MonoBehaviour
    {
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

            int count = Camera.allCameras.Length;
            print("�۾��ƶq :" + count);

            if (Application.isEditor)
            {
                print("�j���O");
            }



        }
        private void Update()
        {
            #region �ǲ�
            int range2 = Random.Range(1, 3);
            print("�H���d�� : " + range2);
            #endregion
            if (Input.anyKey) 
            {
                print("���N��");
            }
            Time.timeScale = 1f;
            
             

        }
    }
}

    
