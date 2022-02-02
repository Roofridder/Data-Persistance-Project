using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenuUIManager : MonoBehaviour
{
    public InputField nameInputField;
    static string playerName;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartNew()
    {
        nameInputField = nameInputField.GetComponent<InputField>();
        playerName = nameInputField.text;
        MenuManager.Instance.playerName = playerName;
        Debug.Log(playerName);
        SceneManager.LoadScene(1);
    }
}
