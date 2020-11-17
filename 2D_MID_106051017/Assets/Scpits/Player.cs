
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public GameObject Final;

    public Text textcount;

    public int count;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "結束指標")
        {
            Final.SetActive(true);
        }

        if (collision.tag == "水果")
        {
            Destroy(collision.gameObject);

            count++;

            textcount.text = count + "/8";
        }
        
    }

}
