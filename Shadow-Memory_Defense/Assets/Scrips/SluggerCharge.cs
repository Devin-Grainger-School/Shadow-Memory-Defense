using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class SluggerCharge : MonoBehaviour
{
    public GameObject Slugger;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            // Launch a projectile from the player
            Instantiate(Slugger, transform.position, Slugger.transform.rotation);
        }
    }
            
}
