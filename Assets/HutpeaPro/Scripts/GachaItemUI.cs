using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GachaItemUI : MonoBehaviour
{
    public Transform parent;

    public void Hide()
    {
        parent.gameObject.SetActive(false);
    }

    public void Show()
    {
        parent.gameObject.SetActive(true);
    }

    public void Setup()
    {

    }
}
