using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerManager : Singleton<TowerManager>
{
    public List<Towers> towerList;

    public static TowerManager instance;
    private void Awake()
    {
        instance = this;
    }
    [System.Serializable]
    public class Towers
    {
        public GameObject PlaceTower;
        public GameObject subMenu;
        public string name;

        public GameObject getPlaceTower()
        {
            return PlaceTower;
        }
        public GameObject getSubMenu()
        {
            return subMenu;
        }
        public string getName()
        {
            return name;
        }
    }
}
