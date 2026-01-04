using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionSceneChange : MonoBehaviour
{
    [SerializeField] private string SceneName;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Scene Col");
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneName);
            Debug.Log("I have scene CHANGED!!");
        }
    }
}
