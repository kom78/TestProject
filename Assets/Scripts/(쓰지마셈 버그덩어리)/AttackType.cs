using UnityEngine;

public class AttackType : MonoBehaviour
{
    //컴포넌트 이름 이상한듯ㅅㅂㅋㅋ
    //무기 교체시 범위 바뀜ㅇㅇ
    [SerializeField] public WeaponType weaponType;
    [SerializeField] private GameObject AttackRange;

    private void Update()
    {
        AttackRange.GetComponent<BoxCollider>().size = new Vector3(weaponType.RangeX, 0, weaponType.RangeZ);
        AttackRange.GetComponent<BoxCollider>().center = new Vector3(0, 0, weaponType.RangeZ/2);
    }
}
