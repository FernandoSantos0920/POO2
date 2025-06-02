using Unity.VisualScripting;
using UnityEngine;

public class MovimentoInimigo : MonoBehaviour

{
    
    public GameObject ataqueObject;
    private GameObject jogador;
    
    public bool andando = false;
    public bool ataque = false;

    public float velocidadeDoAtaque = 1;
    private float ataqueTime = 0;
    
    private Rigidbody rb;
    private float velocidade;

    public float raioDeVisao = 10;
    private bool naVisao = false;
    
    private SphereCollider sphere;

    public float distanciaMinima = 1.5f;

    
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        velocidade = gameObject.GetComponent<Inimigo>().VelocidadeDoPersonagem();
        sphere = gameObject.GetComponent<SphereCollider>();
      
        
        
        jogador = GameObject.FindWithTag("Player");

        ataqueTime = 0;
    }

    
    void Update()
    {
        andando = false;
        ataque = false;
        
        ataqueTime += Time.unscaledDeltaTime;
        Debug.Log( ataqueTime );
        
        
        
        sphere.radius = raioDeVisao;

        if (Vector3.Distance(transform.position, jogador.transform.position) > distanciaMinima)
        {
             if (naVisao == true)
                    {
                        transform.LookAt(jogador.transform.position);
                        transform.position = Vector3.MoveTowards(transform.position, jogador.transform.position, velocidade * Time.deltaTime);
                       
                        
                        
                        andando = true;
                    }
                    ataqueObject.SetActive(false);
        }
        else
        {
            if (ataqueTime >= velocidadeDoAtaque)
            {
                ataqueObject.SetActive(true);
                ataque = true;

                ataqueTime = 0;
            }
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
