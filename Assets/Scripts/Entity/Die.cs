using UnityEngine;

public class Die : MonoBehaviour
{
    private MobType thisMob;

    private void Awake()
    {
        thisMob = GetComponent<MobType>();
    }

    private void Update()
    {
        if (thisMob.entityDefs.Hp <= 0)
        {
            Destroy(transform.gameObject);
        }
    }
}
