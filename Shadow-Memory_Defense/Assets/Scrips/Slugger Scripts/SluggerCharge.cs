using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class SluggerCharge : MonoBehaviour
{
    public GameObject UpSlugger;
    public GameObject DownSlugger;
    public GameObject LeftSlugger;
    public GameObject RightSlugger;
    public GameObject Page;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            // Launch a projectile from the player up
            Instantiate(UpSlugger, transform.position, UpSlugger.transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            // Launch a projectile from the player Down
            Instantiate(DownSlugger, transform.position, DownSlugger.transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            // Launch a projectile from the player Left
            Instantiate(LeftSlugger, transform.position, LeftSlugger.transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            // Launch a projectile from the player Right
            Instantiate(RightSlugger, transform.position, RightSlugger.transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Drops a Page
            Instantiate(Page, transform.position, Page.transform.rotation);
        }
    }
            
}
