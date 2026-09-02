using TMPro;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI cookiecounter;
    [SerializeField] Animator Canvasanimator;
    [SerializeField] int cookies;

    public void Clickedcookie()
     {
        cookies += 1;
        cookiecounter.text = cookies.ToString();
        Canvasanimator.SetTrigger("Click");
     }
}
