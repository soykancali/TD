using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerCreator : MonoBehaviour
{
    public GameObject tower1, tower2, tower3, tower4;
    RaycastHit hit;
    Ray ray;
    int bufferIndex;
    private void Start()
    {
        towerMenu("");
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                menuEvents(hit.transform.name, hit.transform.tag, hit.transform.gameObject);
            }
        }
    }

    void menuEvents(string name, string tag, GameObject hitObj)
    {
        Debug.Log(tag);
        switch (tag)
        {
            case "PlaceTower":
                {
                    towerMenu(name);
                }
                break;
            case "tower":
                {
                    towerSelect(name, hitObj);
                }
                break;
            case "startButton":
                {
                    Lifes.instance.StartSc.SetActive(false);
                    Lifes.instance.readyText.transform.gameObject.SetActive(true);
                    Lifes.instance.readyCounter = true;
                }
                break;
            case "delete":
                {
                    destroyTower(hitObj);
                }
                break;

        }
    }

    void towerMenu(string name)
    {
        for (int i = 0; i < TowerManager.instance.towerList.Count; i++)
        {
            if (TowerManager.instance.towerList[i].getName().Equals(name))
            {
                TowerManager.instance.towerList[i].getSubMenu().SetActive(true);
            }
            else
            {
                TowerManager.instance.towerList[i].getSubMenu().SetActive(false);
            }
        }
    }


    void towerSelect(string name, GameObject hitObj)
    {
        Debug.Log(hitObj.transform.parent.name);

        for (int i = 0; i < TowerManager.instance.towerList.Count; i++)
        {
            if (hitObj.transform.parent.name.Equals(TowerManager.instance.towerList[i].getSubMenu().name))
            {
                Debug.Log(hitObj.transform.parent.name + "\n");
                Debug.Log(name);

                bufferIndex = i;
                break;
            }
        }

        switch (name)
        {
            case "TowerArc":
                {
                    destroyTower(hitObj);
                    Instantiate(tower1, TowerManager.instance.towerList[bufferIndex].getPlaceTower().transform.position, Quaternion.identity).transform.SetParent(GameObject.Find(hitObj.transform.parent.parent.name).transform);
                    TowerManager.instance.towerList[bufferIndex].getPlaceTower().transform.GetChild(0).gameObject.SetActive(false);
                }
                break;

            case "TowerCannon":
                {
                    destroyTower(hitObj);

                    Instantiate(tower2, TowerManager.instance.towerList[bufferIndex].getPlaceTower().transform.position, Quaternion.identity).transform.SetParent(GameObject.Find(hitObj.transform.parent.parent.name).transform);
                    TowerManager.instance.towerList[bufferIndex].getPlaceTower().transform.GetChild(0).gameObject.SetActive(false);
                }
                break;
            case "TowerMage":
                {
                    destroyTower(hitObj);

                    Instantiate(tower3, TowerManager.instance.towerList[bufferIndex].getPlaceTower().transform.position, Quaternion.identity).transform.SetParent(GameObject.Find(hitObj.transform.parent.parent.name).transform);
                    TowerManager.instance.towerList[bufferIndex].getPlaceTower().transform.GetChild(0).gameObject.SetActive(false);
                }
                break;
            case "TowerCatapult":
                {
                    destroyTower(hitObj);

                    Instantiate(tower4, TowerManager.instance.towerList[bufferIndex].getPlaceTower().transform.position, Quaternion.identity).transform.SetParent(GameObject.Find(hitObj.transform.parent.parent.name).transform);
                    TowerManager.instance.towerList[bufferIndex].getPlaceTower().transform.GetChild(0).gameObject.SetActive(false);
                }
                break;
        }
    }

    void destroyTower(GameObject hit)
    {
        if (hit.gameObject.transform.parent.transform.GetChild(0).gameObject)
        {
            Destroy(hit.gameObject.transform.parent.transform.GetChild(0).gameObject);
        }
    }
}
