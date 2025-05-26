using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;

    public float velocidade = 10f;

    private Animator animator;

    public bool andando = false;
    
    
    void Start()
   
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    
    void Update()
    {

        andando = false;
        
        Vector3 position = transform.position;
        
       
        if (Input.GetKey(KeyCode.A))
        {
            position.x = position.x - velocidade * Time.deltaTime;
            animator.SetBool("Andando", andando = true);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            position.x = position.x + velocidade * Time.deltaTime;
            animator.SetBool("Andando", andando = true);
        }

        if (Input.GetKey(KeyCode.S))
        {
            position.z = position.z - velocidade * Time.deltaTime;
            animator.SetBool("Andando", andando = true);
        }

        if (Input.GetKey(KeyCode.W))
        {
            position.z = position.z + velocidade * Time.deltaTime;
            animator.SetBool("Andando", andando = true);
        }
        
        transform.position = position;
    }
     
    
}
