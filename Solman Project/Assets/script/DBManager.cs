using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DBManager : MonoBehaviour
{
    public string userName;
    public string password;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GetUser());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator RegisterUser()
    {
        WWWForm form = new WWWForm();
        //Добавляет информацию в базу ту, которую необходимо. Имя игрока, данные...
        // form.AddField("WelcomeMsg", "Дороу");
        form.AddField("Name", userName);
        form.AddField("Pass", password);
        WWW www = new WWW("https://psina-games.ru/db-app/register.php", form);
        yield return www;
        if(www.error != null)
        {
            Debug.Log("Ошибка: " + www.error);
            yield break;
        }
        Debug.Log("Сервер ответил: " + www.text);
    }

    private IEnumerator GetUser()
    {
        WWWForm form = new WWWForm();
        //Добавляет информацию в базу ту, которую необходимо. Имя игрока, данные...
        // form.AddField("WelcomeMsg", "Дороу");
        form.AddField("Name", userName);
        WWW www = new WWW("https://psina-games.ru/db-app/login.php", form);
        yield return www;
        if (www.error != null)
        {
            Debug.Log("Ошибка: " + www.error);
            yield break;
        }
        Debug.Log("Сервер ответил: " + www.text);
    }
}

