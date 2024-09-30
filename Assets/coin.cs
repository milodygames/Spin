using TMPro;
using UnityEngine;

public class coin : MonoBehaviour
{
   
    private void Update()
    {
        gameObject.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetInt("AppCoins").ToString();
    }

}
