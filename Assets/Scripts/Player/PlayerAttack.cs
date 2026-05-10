using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private AttackType attackType;
    private Combat combat;
    private MobType playerDefs;

    private float damage;

    private void Awake()
    {
        attackType = GetComponentInChildren<AttackType>();
        combat = GetComponentInChildren<Combat>();
        playerDefs = GetComponent<MobType>();
    }
    private void Start()
    {
        damage = playerDefs.entityDefs.Damage;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            combat.GiveDamage(damage + attackType.weaponType.WeaponDamage);
            // 여기에 무기 딜레이 추가해야됨ㅇㅇ attackType.weaponType.WeaponDelay
        }
    }
}
