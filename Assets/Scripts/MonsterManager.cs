using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MonsterManager : MonoBehaviour
{
    public float monsterCreateTime = 1f;
    public GameObject orc, bat;
    public GameObject SpawnPoint;
    int bufferIndex;

    private void Start()
    {

        InvokeRepeating("creator", 1f, monsterCreateTime);

    }
    void creator()
    {
        Instantiate(orc, SpawnPoint.transform.position, Quaternion.identity);
    }
}

//    private void monsterSelect(string name, string tag)
//    {
//        switch (tag)
//        {
//            case "monster":
//                {
//                    monsterCreator(name);

//                }
//                break;
//        }

//    }
//    private void monsterCreator(string name)
//    {


//        switch (name)
//        {
//            case "orc":
//                {
//                    //Instantiate(orc, MonsterList.instance.monsterList[bufferIndex].getMonsterGo().transform.position, Quaternion.identity);
//                    //MonsterList.instance.monsterList[bufferIndex].getPlaceTower().SetActive(false);
//                    orc = MonsterList.instance.monsterList[0].getMonsterGo();
//                    Instantiate(bat, SpawnPoint.transform.position, Quaternion.identity);
//                }
//                break;

//            case "bat":
//                {
//                    bat = MonsterList.instance.monsterList[1].getMonsterGo();
//                    Instantiate(bat, SpawnPoint.transform.position, Quaternion.identity);

//                }
//                break;
//        }


//    }
//}

/*sonra düzenlenecek
 *  private void monsterFinder(string name, string tag)
 {
     switch (tag)
     {
         case "MonsterGo":
             {
                 monsterSelect(name);
             }
             break;
         case "monster":
             {
                 monsterCreator(name);
             }
             break;
     }
 }
 void Creator()
 {


 }
 private void Update()
 {
     monsterFinder(MonsterList.instance.monsterList[bufferIndex].name,MonsterList.instance.monsterList[bufferIndex].name);
 }

 private void monsterSelect(string name)
 {
     for (int i = 0; i < MonsterList.instance.monsterList.Count; i++)
     {
         if (MonsterList.instance.monsterList[i] != null)
         {

             bufferIndex = i;
             break;
         }
     }

 }

 private void monsterCreator(string name)
 {


     switch (name)
     {
         case "orc":
             {
                 //Instantiate(orc, MonsterList.instance.monsterList[bufferIndex].getMonsterGo().transform.position, Quaternion.identity);
                 //MonsterList.instance.monsterList[bufferIndex].getPlaceTower().SetActive(false);
                 orc = MonsterList.instance.monsterList[bufferIndex].getMonsterGo();
                 Instantiate(bat, SpawnPoint.transform.position, Quaternion.identity);
             }
             break;

         case "bat":
             {
                 bat = MonsterList.instance.monsterList[bufferIndex].getMonsterGo();
                 Instantiate(bat, SpawnPoint.transform.position, Quaternion.identity);

             }
             break;
     }
 }
 */

