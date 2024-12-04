using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Gambling : MonoBehaviour
{
    [SerializeField] public List<Image> slots = new List<Image>();
    
    [SerializeField] Inventory[] items;
    [SerializeField] TextMeshProUGUI name;
    [SerializeField] TextMeshProUGUI classS;
    [SerializeField] TextMeshProUGUI cost;
    [SerializeField] TextMeshProUGUI classss;
    [SerializeField] Image mainImage;
    int id;
    public void VoidSpirit()
    {
        if (id >= slots.Count) return;
        Inventory currentItem = items[Random.Range(0, items.Length)];
        slots[id].sprite = currentItem.Icon;
        name.text = currentItem.Name;
        classS.text = currentItem.Things.ToString();
        cost.text = currentItem.Cost.ToString();
        mainImage.sprite = currentItem.Icon;
        classss.text = currentItem.States.ToString();
        id++;
    }

    
}
