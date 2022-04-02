
using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "ItemInfo", menuName = "ItemInfo")]
public class ItemInfo : ScriptableObject, IItemInfo
{
    [SerializeField] protected string _name;
    [SerializeField] protected Sprite _icon;
    [SerializeField] protected int _maxQuantity;
    [SerializeField] protected ItemType _type;
    [SerializeField] protected GameObject _prefab;
    public string Name => _name;
    public Sprite Icon => _icon;
    public ItemType Type => _type;
    public int MaxQuantity => _maxQuantity;
    public GameObject Prefab => _prefab;
}