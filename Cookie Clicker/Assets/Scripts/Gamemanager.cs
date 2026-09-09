using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class Gamemanager : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI cookiecounter;
    [SerializeField] Animator Canvasanimator;
    [SerializeField] TextMeshProUGUI grandmacounter;
    [SerializeField] TextMeshProUGUI grandmapricecounter;
    [SerializeField] TextMeshProUGUI mafiacounter;
    [SerializeField] TextMeshProUGUI mafiapricecounter;
    [SerializeField] TextMeshProUGUI factorycounter;
    [SerializeField] TextMeshProUGUI factorypricecounter;
    [SerializeField] UnityEngine.UI.Button buttonbronzeclick;
    [SerializeField] int cookies;
    int clickmult = 1;
    bool bronzeclickbefore = false;
    bool silverclickbefore = false;
    bool goldclickbefore = false;
    bool platinumclickbefore = false;
    int buildingmult = 1;
    bool upgradedbuildingbefore = false;
    bool premiumbuildingbefore = false;
    float timer = 0;
    int grandmas;
    int grandmaprice = 10;
    int mafias;
    int mafiaprice = 75;
    int factories;
    int factoryprice = 500;

    public void boughtgrandma()
    {
        if (grandmaprice <= cookies)
        {
            cookies -= grandmaprice;
            cookiecounter.text = cookies.ToString();
            grandmas += 1;
            grandmacounter.text = grandmas.ToString();
            grandmaprice += 10;
            grandmapricecounter.text = grandmaprice.ToString() + (" cookies");
        }
    }

    public void boughtmafia()
    {
        if (mafiaprice <= cookies)
        {
            cookies -= mafiaprice;
            cookiecounter.text = cookies.ToString();
            mafias += 1;
            mafiacounter.text = mafias.ToString();
            mafiaprice += 75;
            mafiapricecounter.text = mafiaprice.ToString() + (" cookies");
        }
    }

    public void boughtfactory()
    {
        if (factoryprice <= cookies)
        {
            cookies -= factoryprice;
            cookiecounter.text = cookies.ToString();
            factories += 1;
            factorycounter.text = factories.ToString();
            factoryprice += 500;
            factorypricecounter.text = factoryprice.ToString() + (" cookies");
        }
    }

    private void Update()
    {
        if (grandmas >= 1)
        {
            timer += Time.deltaTime;
            if (timer >= 1)
            {
                timer = 0;
                Addcookie(grandmas * buildingmult);
            }
        }
        if (mafias >= 1)
        {
            timer += Time.deltaTime;
            if (timer >= 1)
            {
                timer = 0;
                Addcookie(mafias * 10 * buildingmult);
            }
        }
        if (factories >= 1)
        {
            timer += Time.deltaTime;
            if (timer >= 1)
            {
                timer = 0;
                Addcookie(factories * 100 * buildingmult);
            }
        }
    }

    public void upgradedbuildings()
    {
        if (cookies >= 200)
        {
            if (upgradedbuildingbefore == false)
            {
                cookies -= 200;
                buildingmult = 2;
                cookiecounter.text = cookies.ToString();
                upgradedbuildingbefore = true;
            }
        }
    }

    public void premiumbuildings()
    {
        if (upgradedbuildingbefore == true)
        {
            if (cookies >= 2000)
            {
                if (premiumbuildingbefore == false)
                {
                    cookies -= 2000;
                    buildingmult = 10;
                    cookiecounter.text = cookies.ToString();
                    premiumbuildingbefore = true;
                }
            }
        }
        
    }
    public void bronzeclick()
    {
        if (cookies >= 20)
        {
            if (bronzeclickbefore == false)
            {
                cookies -= 20;
                clickmult = 2;
                cookiecounter.text = cookies.ToString();
                bronzeclickbefore = true;
            }
        }
    }
        
    public void silverclick()
    {
        if (bronzeclickbefore == true)
        {
            if (cookies >= 100)
            {
                if (silverclickbefore == false)
                {
                    cookies -= 100;
                    clickmult = 5;
                    cookiecounter.text = cookies.ToString();
                    silverclickbefore = true;
                }
            }
        }
    }
    public void goldclick()
    {
        if (silverclickbefore == true)
        {
            if (cookies >= 200)
            {
                if (goldclickbefore == false)
                {
                    cookies -= 200;
                    clickmult = 10;
                    cookiecounter.text = cookies.ToString();
                    goldclickbefore = true;
                }
            }
        }
    }
    public void platinumclick()
    {
        if (goldclickbefore == true)
        {
            if (cookies >= 1500)
            {
                if (platinumclickbefore == false)
                {
                    cookies -= 1500;
                    clickmult = 100;
                    cookiecounter.text = cookies.ToString();
                    platinumclickbefore = true;
                }
            }
        }
    }
    public void Clickedcookie()
     {
        cookies += clickmult;
        cookiecounter.text = cookies.ToString();
        Canvasanimator.SetTrigger("Click");
     }

    public void Addcookie(int n)
    {
        cookies += n;
        cookiecounter.text = cookies.ToString();
    }
}