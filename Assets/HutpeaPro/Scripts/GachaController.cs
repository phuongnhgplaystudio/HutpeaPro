using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using UnityEngine;

public class GachaController : MonoBehaviour
{
    public GameItemInfo gameItemInfo;
    public GameObject gachaItemUIPrefab;
    public Transform container;
    public AudioSource audioSource;
    public AudioClip openSoundNormal;
    public AudioClip openSoundLegend;

    public void Open(int amount)
    {
        foreach(Transform c in container)
        {
            Destroy(c.gameObject);
        }
        List<GachaItemUI> itemList = new List<GachaItemUI>();
        for(int i = 1; i <= amount; i++)
        {
            GameObject gachaItemObj = UnityEngine.Object.Instantiate(gachaItemUIPrefab, container);
            gachaItemObj.transform.localRotation = Quaternion.Euler(0, -180f, 0);
            GachaItemUI gachaItemUIScript = gachaItemObj.GetComponent<GachaItemUI>();
            gachaItemUIScript.Hide();
            itemList.Add(gachaItemUIScript);
        }

        Sequence s = DOTween.Sequence();
        foreach(var item in itemList)
        {
            //ItemInfo itemInfo = gameItemInfo.GetItemInfoFromType(item.)
            item.Setup();
            s.AppendCallback(delegate
            {
                item.Show();
            });
            s.Append(item.transform.DORotate(new Vector3(0, 0, 0), .25f));
            s.AppendCallback(delegate
            {
                audioSource.PlayOneShot(openSoundNormal);
            });
            s.AppendInterval(0.2f);
        }
    }

    public ItemWithAmountData DrawItemFromConfig()
    {
        ItemWithAmountData result = null;
        return result;
    }
}
