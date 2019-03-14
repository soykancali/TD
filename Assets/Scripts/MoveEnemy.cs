using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MoveEnemy : Singleton<MoveEnemy>
{   //noktalarımızı tuttugumuz listemiz
    [SerializeField]
    public Transform[] waypoints;
    [SerializeField]
   public static float moveSpeed = 0.5f;
    public static int reach=0;
    // yolumuzu tutan listemizin indexini belirliyoruz 0dan başlayıp 10-20 kaç noktamız varsa tek tek artırıp a-->b b-->c... gibi hareket ettirecegiz
    private int waypointIndex = 0;
    // can barımız
    public Slider monsterHealth;
    public float health;



    // sadece başlangıçta çalışan fonksyonumuz
    private void Start()
    {
        
        // monsterımıza ilk yürüyecegi noktayı atıyoruz
        transform.position = waypoints[waypointIndex].transform.position;
    }

    // sürekli çagırılan fonsyonumuz
    private void Update()
    {
        
        
        // yürütme metodumuzu çagırdık
        Move();
    }

    // yürütme metodumuz
    private void Move()
    {
        // monster son noktaya erişene kadar süreki devam ediyoruz
        if (waypointIndex <= waypoints.Length - 1)
        {

            // monster bir noktadan digerine movetowards metodu ile ilerliyo 
            //metod 3 parametre alıyor şuanki noktası,gidilecek nokta ve mesafe
            transform.position = Vector2.MoveTowards(transform.position,
               waypoints[waypointIndex].transform.position,
               moveSpeed * Time.deltaTime);

            //monster istenen noktaya eriştiyse index 1 artılıp gidecegi sonraki pozisyonu belirliyoruz
            if (transform.position == waypoints[waypointIndex].transform.position)
            {
                waypointIndex += 1;
            }
            //son waypointteyse reachı bir artırdık 
            if (waypointIndex == waypoints.Length)
            {
                reach = +1;
                
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        //monsterimize bullet tagında nesne degerse canını azaltıyoruz,bullet nesnemizi yokediyoruz monsterin healtı 0 olursada monsterimizi yokediyoruz
        if (other.tag.Equals("bullet"))
        {
            monsterHealth.value -= 0.5f;
            health -= 0.5f;
            Destroy(other.gameObject);
            if (health <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag.Equals("bullet"))
        {
            monsterHealth.value -= 0.5f;
            health -= 0.5f;
            Destroy(other.gameObject);
            if (health <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }

}