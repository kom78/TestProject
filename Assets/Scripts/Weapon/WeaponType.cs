using UnityEngine;

[CreateAssetMenu(fileName = "WeaponType", menuName = "WeaponType", order = 0)]
public class WeaponType : ScriptableObject {
    [SerializeField] float rangeX;
    //[SerializeField] float rangeY;
    [SerializeField] float rangeZ;

    [SerializeField] string weaponName;
    [SerializeField] float weaponDamage;
    [SerializeField] float durability;
    [SerializeField] float weaponDelay;
    [SerializeField] GameObject weaponModel;

    public float RangeX => rangeX;
    //public float RangeY => rangeY;
    public float RangeZ => rangeZ;

    public float WeaponDamage => weaponDamage;
    public float WeaponDelay => weaponDelay;
}