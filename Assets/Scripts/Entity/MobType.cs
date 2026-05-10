using UnityEngine;
using UnityEngine.UI;


[System.Serializable]
public class DefsOfEntity
{
    [SerializeField] private Image icon;
    [SerializeField] private string entityName;
    [SerializeField] private float hp;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float damage;
    [SerializeField] private float lv;

/*
    public Image Icon
{
    get => icon;
    set => icon = value;
}
*/
public string Name
{
    get => entityName;
    //set => entityName = value;
}

public float Hp
{
    get => hp;
    set => hp = value;
}

public float MoveSpeed
{
    get => moveSpeed;
    set => moveSpeed = value;
}

public float Damage
{
    get => damage;
    set => damage = value;
}

public float Lv
{
    get => lv;
    set => lv = value;
}
}
public class MobType : MonoBehaviour
{
    public DefsOfEntity entityDefs;
}
