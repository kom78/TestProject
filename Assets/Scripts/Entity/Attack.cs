using UnityEngine;
//컴포넌트 추가할 필요 없음ㅇㅇ
public abstract class Attack : MonoBehaviour
{
    private MobType target = null;
    private bool isTargetHere = false;

    private void Update()
    {
        DoAttack();
    }
    protected void GiveDamage(float damage)
    {
        if (target != null)
            {
                target.entityDefs.Hp -= damage;
                Debug.Log(target.entityDefs.Hp);   
            }
    }

    public abstract void DoAttack(); //추상화ㅇㅇ

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
