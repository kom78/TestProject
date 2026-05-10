using UnityEngine;

public abstract class Attack : MonoBehaviour
{
    private AttackType attackType;
    private Combat combat;
    private MobType itDefs;

    private float damage;

    private void Awake()
    {
        attackType = GetComponentInChildren<AttackType>();
        combat = GetComponentInChildren<Combat>();
        itDefs = GetComponent<MobType>();
    }
    private void Start()
    {
        damage = itDefs.entityDefs.Damage; // 객체 데미지 받아오기임ㅇㅇ
    }

    public abstract void GiveDamage();

}
