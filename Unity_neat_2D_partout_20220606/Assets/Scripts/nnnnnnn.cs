using UnityEngine;

public class nnnnnnn : MonoBehaviour
{
    [SerializeField]
    private SphereCollider Sphere1;//���
    [SerializeField]
    private CapsuleCollider cap;//���n
    [SerializeField]
    private BoxCollider cube;//���
    [SerializeField]
    private Camera cam;
    [SerializeField]
    private Rigidbody rig;





    void Start()
    {
        

        print("��v���`��" + Camera.main.depth);
        print("�y��I���b�|" + Sphere1.radius);

        Camera.main.backgroundColor = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);





    }


    private void Update()
    {

        cap.transform.localScale = new Vector3(3, 2, 1);

        rig.AddForce(new Vector3(0,30, 0));

        cube.transform.RotateAround(Sphere1.transform.localPosition, Vector3.up, 20);
       
       

    }



}
