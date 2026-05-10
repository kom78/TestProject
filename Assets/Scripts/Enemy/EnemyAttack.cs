using UnityEngine;

public class EnemyAttack : Attack
{
    private MobType itDefs;

    private float damage;

    public override void DoAttack()
    {
        //공격조건 추가
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
