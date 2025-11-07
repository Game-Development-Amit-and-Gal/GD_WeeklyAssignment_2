using UnityEngine;
using UnityEngine.InputSystem;

public class PersonScript : MonoBehaviour
{
    private InputAction hidePlayer;
    private bool isVisiable = true;
    private Renderer[] playerRenderer;

    void OnEnable()
    {
        playerRenderer = GetComponentsInChildren<Renderer>();
        hidePlayer = new InputAction(type: InputActionType.Button, binding: "Keyboard/space");
        hidePlayer.Enable();

        hidePlayer.performed += ctx => ToggleVisibility();

    }

    private void OnDisable()
    {
        hidePlayer.Disable();
    }

    private void ToggleVisibility()
    {
        isVisiable = !isVisiable;
        foreach( Renderer rend in playerRenderer)
        {
            rend.enabled = isVisiable;
        }

    }
}
