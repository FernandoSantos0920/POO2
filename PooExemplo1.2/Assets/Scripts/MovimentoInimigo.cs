using Unity.VisualScripting;
using UnityEngine;

public class MovimentoInimigo : MonoBehaviour

{
    
    private GameObject jogador;
    
    private Rigidbody rb;
    private float velocidade;

    
    public float raioDeVisao = 10f;
    private bool naVisao = false;

    private SphereCollider sphere;
    
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        velocidade = gameObject.GetComponent<Inimigo>().VelocidadeDoPersonagem();
        sphere = gameObject.GetComponent<SphereCollider>();
      
        
        
        jogador = GameObject.FindWithTag("Player");
    }

    
    void Update()
    {
        sphere.radius = raioDeVisao;
        if (naVisao = true)
        {
            transform.LookAt(jogador.transform.position);
            transform.position = Vector3.MoveTowards(transform.position, jogador.transform.position, velocidade * Time.deltaTime);
           
        }
        
        
    }

    void OnTriggerStay(Collider colisao)
    {
        if (colisao.gameObject.CompareTag("Player"))
        {
            naVisao = true;
        }
        
        
        
        
    }

    private void OnTriggerExit(Collider colisao)
    {
        if (colisao.gameObject.CompareTag("Player"))
        {
            naVisao = false;
        }
    }
    
    
}
