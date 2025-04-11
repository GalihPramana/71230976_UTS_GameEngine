using UnityEngine;
using UnityEngine.SceneManagement;

public class HalamanManager : MonoBehaviour
{
    public bool isEscapeToExit;

    void Update()
    {

    }

    public void MulaiPermainan()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void KembaliKeMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
