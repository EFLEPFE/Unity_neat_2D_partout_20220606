using UnityEngine;

public class nnnnnnn : MonoBehaviour
{
    [SerializeField]
    private SphereCollider Sphere1;//圓形
    [SerializeField]
    private CapsuleCollider cap;//膠囊
    [SerializeField]
    private BoxCollider cube;//方塊
    [SerializeField]
    private Camera cam;
    [SerializeField]
    private Rigidbody rig;





    void Start()
    {
        

        print("攝影機深度" + Camera.main.depth);
        print("球體碰撞半徑" + Sphere1.radius);

        Camera.main.backgroundColor = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);





    }


    private void Update()
    {

        cap.transform.localScale = new Vector3(3, 2, 1);

        rig.AddForce(new Vector3(0,30, 0));

        cube.transform.RotateAround(Sphere1.transform.localPosition, Vector3.up, 20);
       
       

    }



}
