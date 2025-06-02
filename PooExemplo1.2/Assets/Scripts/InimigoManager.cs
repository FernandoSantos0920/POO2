using UnityEngine;

public class InimigoManager : MonoBehaviour
{
  
    public Animator animator;   
    private MovimentoInimigo movimentoInimigo;
    public float velocidadeDaAnimacao = 1f;
    
    
    void Start()
    {
        movimentoInimigo = GetComponent<MovimentoInimigo>();
    }

    
    void Update()
    {
        animator.SetBool("Andando", movimentoInimigo.andando);
       
        
        if (movimentoInimigo.ataque = true)
        {
            animator.SetTrigger("Ataque");  
        }
    }
}
