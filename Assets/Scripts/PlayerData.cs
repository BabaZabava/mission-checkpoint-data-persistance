using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerData : MonoBehaviour
{
    public static PlayerData Instance;
    public string playerName;
    public GameObject warningText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void Awake()
    {

        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void StartNew()
    {
        if (playerName == "")
        {
            warningText.SetActive(true);
           
        }
        else
        {
            warningText.SetActive(false);
            SceneManager.LoadScene(1);
        }

    }

    public void ReadStringInput(string input)
    {
        playerName = input;
        Debug.Log("PLayer name: " + playerName);
    }
}
