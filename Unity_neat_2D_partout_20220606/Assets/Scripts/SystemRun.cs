
using UnityEngine;    //�ޥ� Unity �v�� �R�W�Ŷ�(API)

namespace neat
{
    // C# �q�Ź��ܦ����骫��
    // 1.�����W���C������ Game Object �Ǧ�u�����
    // 2.�N���}�����b�Ӫ����ܦ�����

    /// <summary>
    /// �]�B�t��
    /// </summary>

    public class SystemRun : MonoBehaviour
    {
        #region ���:�O�s���
        // ��� Field :�O�s���
        // �y�k :
        //�׹��� ��������� ���ۭq�W�� (���w �w�]��)

        //�׹��� 
        //���} : ��ܦb���O�A���\��L���O�s��          public 
        //�p�H : ����ܦb���O�A�����\��L���O�s��       private (�ʸ�) 

        //SerializeField Field �ǦC����� : �N�p�H������
        //Header ���D : �i�H�ϥΤ���
        //Tooltip ���� : �i�H�ϥΤ���
        //Range �d�� : �ȭ���ƭ�������� int ,float ,byte ,long

        [SerializeField, Header("�]�B�t��"), Tooltip("5�o�O�]�B�t��"), Range(0,100)]
        private float speedRun = 10f;
        private float maxspeedRun = 100;
        

        private Animator ani;
        private Rigidbody2D rig;



        #endregion

        #region �\��:��@�Өt�ν�����k

        // ��k Method
        // �y�k :
        //�׹��� �Ǧ^�������  ��k�W��(�Ѽ�) { �{�� }
        /// <summary>
        /// �]�B�\��
        /// </summary>
        private void Run()
        {
            //print("�]�B��!!!!!!");
            rig.velocity = new Vector2(speedRun, rig.velocity.y);

            
        }

        #endregion

        #region �ƥ�:�����J�f
        //����ƥ� : �}�l�ƥ�e����@���A���o���󵥵�
        private void Awake()
        {
            // ani ���w �Ԫ��t���W�� Animator
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }


        // �}�l�ƥ� : ����C���ɰ���@��
        // ��l�Ƴ]�w �A�Ҧp : �^���p�� 500 �� . �ͩR��l�� 3 �� ...
        private void Start()
        {
            //print("���o  �Ф��n����!!!");            
        }

       


        // ��s�ƥ� : �C���������Q�� 60FPS Frame
        private void Update()
        {
            //print("<color=yellow>��s�ƥ���椤!!!</color>");

            //�I�s��k�G��k�W��(�������޼�);
            Run();

        }
        #endregion

        private void OnEnable()
        {
            
        }

        private void OnDisable()
        {
            // �[�t���k�s
            rig.velocity = Vector3.zero;
        }
    }

}



