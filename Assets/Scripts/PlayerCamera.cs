using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] private GameObject Player;

    [SerializeField] private float camSpeed;

    [SerializeField] private float posX;
    [SerializeField] private float posY;
    [SerializeField] private float posZ;

    private void FixedUpdate()
    {
        Vector3 camPos = new Vector3(Player.transform.position.x + posX, Player.transform.position.y + posY, Player.transform.position.z + posZ);

        transform.position = Vector3.Lerp(transform.position, camPos, camSpeed * Time.fixedDeltaTime);
    }
}
