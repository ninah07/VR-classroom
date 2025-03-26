using UnityEngine;
using UnityEngine.UI;

public class recButton : MonoBehaviour
{
    public GameObject cameraOverlay;
    public Button recordButton;

    private void Start()
    {
        recordButton.onClick.AddListener(ToggleButton);
    }

    private void ToggleButton()
    {
        cameraOverlay.SetActive(!cameraOverlay.activeSelf);
    }
}
