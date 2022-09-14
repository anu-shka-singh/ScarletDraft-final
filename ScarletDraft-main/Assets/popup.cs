using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class popup : MonoBehaviour
{

    
    [SerializeField]
    private GameObject clue1;
    float cameraPitch = 0.0f;
    Transform playerCamera;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ShowCursor();
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                HideCursor();
            }
            cameraPitch = Mathf.Clamp(cameraPitch, 0.0f, 0.0f);
            playerCamera = null;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            HideCursor();
        }
    }


    public void ShowCursor()
    {

        clue1.SetActive(true);

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void HideCursor()
    {

        clue1.SetActive(false);

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
