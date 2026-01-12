using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void OpenMenu()
    {
        gameObject.SetActive(true);
    }

    public void CloseMenu()
    {
        gameObject.SetActive(false);
    }
}
