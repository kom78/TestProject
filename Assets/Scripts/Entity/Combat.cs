using UnityEngine;

public class Combat : MonoBehaviour
{
    public MobType target = null;

    private bool isTargetHere = false;
    
    public void GiveDamage(float damage)
    {
        if (target != null)
        {
            target.entityDefs.Hp -= damage;
            Debug.Log(target.entityDefs.Hp);   
        }
    }

    private void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("Mob"))
    {
        MobType mob = other.GetComponentInParent<MobType>();

        if (mob != null && mob != GetComponentInParent<MobType>())
        {
            isTargetHere = true;
            target = other.GetComponentInParent<MobType>();
        }
    }
}
    private void OnTriggerExit(Collider other)
    {
        isTargetHere = false;
        target = null;
    }
}
