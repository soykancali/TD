using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterList : Singleton<MonsterList>
{
    public List<Monster> monsterList;
    public static MonsterList instance;
    private void Awake()
    {
        instance = this;
    }
     [System.Serializable]
     public class Monster
    {
        public GameObject monsterGo;
        public string name;
        public GameObject getMonsterGo()
        {
            return monsterGo;
        }
        public string getName()
        {
            return name;
        }
    }
}

