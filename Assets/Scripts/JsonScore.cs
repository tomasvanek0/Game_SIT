using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class JsonScore : MonoBehaviour
{
    string savePath;

    public static JsonScore Instance;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    void Start()
    {
        savePath = Application.persistentDataPath + "/save.json"; 
    }

    public void SaveGame()
    {
        SaveScore data = new SaveScore();

        data.score = GameManager.Instance.score;
       

        string json = JsonUtility.ToJson(data, true);

        File.WriteAllText(savePath, json);

        Debug.Log("Hra uložena do: " + savePath);
    }
    public void LoadGame()
    {
        if (File.Exists(savePath))
        {
            string json = File.ReadAllText(savePath);

            SaveScore data = JsonUtility.FromJson<SaveScore>(json);

            Debug.Log(data.score);

        }
        else
        {
            Debug.Log("Save soubor neexistuje");
        }
    }
}

