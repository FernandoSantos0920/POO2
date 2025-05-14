using Unity.VisualScripting;
using UnityEngine;

public class MovimentoInimigo : MonoBehaviour

{
    
    private GameObject jogador;
    public GameObject ataqueObject;
    
    private Rigidbody rb;
    private float velocidade;

    
    public float raioDeVisao = 10f;
    private bool naVisao = false;

    private SphereCollider sphere;
    
    
    public float distanciaMinima = 1.5f;
    
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

        if (Vector3.Distance(transform.position, jogador.transform.position) > distanciaMinima)
        {
             if (naVisao = true)
                    {
                        transform.LookAt(jogador.transform.position);
                        transform.position = Vector3.MoveTowards(transform.position, jogador.transform.position, velocidade * Time.deltaTime);
                       
                    }
                    ataqueObject.SetActive(false);
        }
        else
        {
            ataqueObject.SetActive(true);
        }

        Debug.DrawLine(transform.position, jogador.transform.position, Color.red);
        
        
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
