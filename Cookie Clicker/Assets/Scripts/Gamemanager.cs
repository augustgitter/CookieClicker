using TMPro;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI cookiecounter;
    
    [SerializeField] int cookies;

    public void Clickedcookie()
     {
        cookies += 1;
        cookiecounter.text = cookies.ToString();
     }
}
