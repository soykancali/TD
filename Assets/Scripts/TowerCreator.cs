using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerCreator : MonoBehaviour
{
    public GameObject tower1, tower2, tower3, tower4;
    RaycastHit hit;
    Ray ray;
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
    int bufferIndex;

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
                    Instantiate(tower1, TowerManager.instance.towerList[bufferIndex].getPlaceTower().transform.position, Quaternion.identity);
                    TowerManager.instance.towerList[bufferIndex].getPlaceTower().SetActive(false);
                }
                break;

            case "TowerCannon":
                {
                    Instantiate(tower2, TowerManager.instance.towerList[bufferIndex].getPlaceTower().transform.position, Quaternion.identity);
                    TowerManager.instance.towerList[bufferIndex].getPlaceTower().SetActive(false);
                }
                break;
            case "TowerMage":
                {
                    Instantiate(tower3, TowerManager.instance.towerList[bufferIndex].getPlaceTower().transform.position, Quaternion.identity);
                    TowerManager.instance.towerList[bufferIndex].getPlaceTower().SetActive(false);
                }
                break;
            case "TowerCatapult":
                {
                    Instantiate(tower4, TowerManager.instance.towerList[bufferIndex].getPlaceTower().transform.position, Quaternion.identity);
                    TowerManager.instance.towerList[bufferIndex].getPlaceTower().SetActive(false);
                }
                break;
        }
    }
}
