using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void ChangeScene(string SceneName)
    {
        // changes the scene
        SceneManager.LoadScene(SceneName);
    }
}
