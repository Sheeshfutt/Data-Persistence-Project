using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    public InputField inputField;
    public void StartGame()
    {
        PersistenceManager.Instance.player = inputField.text;
        SceneManager.LoadScene(1);
    }
}
