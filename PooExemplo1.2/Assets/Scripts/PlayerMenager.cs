using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerMenager : MonoBehaviour

{
    public Animator animator;
    private Player movimentoPlayer;
    public float velocidadeDaAnimacao = 1;
    
    private Personagem personagem;
    
    
    void Start()
    {
        movimentoPlayer = GetComponent<Player>();
        personagem = GetComponent<Personagem>();
    }
    void Update()
    {
        animator.SetBool("Andando", movimentoPlayer.andando);
        animator.speed = velocidadeDaAnimacao;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Ataque");  
        }

        if (personagem.EnergiaDoPersonagem() <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
           
        }

    }
}