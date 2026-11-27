using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField]
    private int m_SceneIndex = 0;

    public void LoadScene()
    {
        // SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        SceneManager.LoadScene(m_SceneIndex);
    }
}
