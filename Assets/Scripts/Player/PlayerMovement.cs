using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float rotSpeed;
    private MobType mob;
    private Rigidbody rb;

    private Vector3 moveDir;

    private void Awake() {
        mob = GetComponent<MobType>();
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputZ = Input.GetAxisRaw("Vertical");

        moveDir = new Vector3(inputX, 0 , inputZ).normalized ;

        rb.linearVelocity = moveDir * mob.entityDefs.MoveSpeed;

        if (moveDir != Vector3.zero)       
        {            
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, Mathf.Atan2(inputX, inputZ) * Mathf.Rad2Deg, 0), rotSpeed * Time.deltaTime);
        }
    }
}
