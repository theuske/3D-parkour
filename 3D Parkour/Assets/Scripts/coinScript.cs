using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinScript : MonoBehaviour
{
    public AudioClip coinsound;
    public GameHandler GH;
    // Start is called before the first frame update
    void Start()
    {
        GH = GameObject.Find("Canvas").GetComponent<GameHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
            GH.Coins++;
            Destroy(gameObject);
        AudioSource.PlayClipAtPoint(coinsound, transform.position);
            Debug.Log("Coin collected");
    }
}
