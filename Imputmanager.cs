using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Imputmanager : MonoBehaviour
{
    private PlayerInput playerImput;
    private PlayerInput.OnFootActions onfoot;
    // Start is called before the first frame update
    void Awake()
    {
        playerInput = new playerInput();
        onfoot = playerInput.OnFoot;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnEnable()
    {
        onfoot.Enable();
    }
    private void OnDisable()
    {
        onfoot.Disable();
    }
}
