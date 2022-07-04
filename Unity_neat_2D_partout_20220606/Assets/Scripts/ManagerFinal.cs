using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

namespace neat 
{
    /// <summary>
    ///  �޲z�����e��
    ///  �L���P����
    /// </summary>
    public class ManagerFinal : MonoBehaviour
    {
        [SerializeField, Header("�e��")]
        private CanvasGroup groupFinal;
        [SerializeField, Header("�C���������D")]
        private TextMeshProUGUI textFinal;

        /// <summary>
        ///  �C���������D��r���e
        /// <summary>
        public string stringTitle;

        private void Start()
        {
            textFinal.text = stringTitle;
            // MonoBehaviour ���O API  �i�H�����ϥΦW�٩I�s
            InvokeRepeating("FadeIn", 0, 0.2f);
        }


        /// <summary>
        ///  �H�J 
        /// <summary>

        private void FadeIn() 
        {
            // �z���׻��W
            groupFinal.alpha += 0.1f;
            print("�H�J~");

            // �p�G �z���� >=1 �N�Ұʤ��ʻP�B�׵��u
            if (groupFinal.alpha >= 1) 
            {
                groupFinal.interactable       = true;
                groupFinal.blocksRaycasts = true;
                CancelInvoke("FadeIn");

                
            }

        }

        // ���s�P�{�����q�覡
        // 1.�w�q���}��k
        // 2.Button On Click �]�w���}�������}��k
        public void Quit()
        {
            print("���}�C��");
            Application.Quit();
        }

        /// <summary>
        ///  ���s�C��
        /// <summary>

        public void Relay() 
        {
            SceneManager.LoadScene("�C������");
        }
    }
}

