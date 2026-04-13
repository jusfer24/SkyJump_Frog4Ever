using UnityEngine;

public class NewRecordController : MonoBehaviour
{
    public Animator animator;
    public GameObject winimg;
    private bool iswin = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            animator.SetBool("iswinning", iswin);
            winimg.SetActive(true);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
