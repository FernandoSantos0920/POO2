using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;

    public float velocidade = 10f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

   
    void Update()
    {
        
        Vector3 position = transform.position;

        if (Input.GetKey(KeyCode.A))
        {
            position.x = position.x - velocidade * Time.deltaTime;
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            position.x = position.x + velocidade * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            position.z = position.z - velocidade * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.W))
        {
            position.z = position.z + velocidade * Time.deltaTime;
        }
        
        transform.position = position;
    }
     
    
}
