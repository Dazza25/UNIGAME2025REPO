using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CollectableManager : MonoBehaviour
{

    public int collectableCount;
    public TextMeshProUGUI collectableText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        collectableText.text = "Collectables " + collectableCount.ToString() + "/3";

        if (collectableCount == 3)
        {
            SceneManager.LoadScene("Engine");
        }
    }
}
