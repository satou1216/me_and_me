using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class select : MonoBehaviour
{

    [SerializeField]
    private GameObject FirstSelect;
    // Use this for initialization
    void Start()
    {
        EventSystem.current.SetSelectedGameObject(FirstSelect);
    }
}