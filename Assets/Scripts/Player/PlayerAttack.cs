using UnityEngine;

public class PlayerAttack : Attack
{
    private MobType itDefs;

    private float damage;

    public override void DoAttack()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GiveDamage(damage);
        }
    }

    private void Awake()
    {
        itDefs = GetComponent<MobType>();
    }
    private void Start()
    {
        this.damage = itDefs.entityDefs.Damage; // 객체 데미지 받아오기임ㅇㅇ
    }
}
