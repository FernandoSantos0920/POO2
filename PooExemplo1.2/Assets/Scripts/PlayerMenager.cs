using UnityEngine;

public class PlayerMenager : MonoBehaviour

{
    private Player player;
    public Animator animator;
    public float animation_velocity = 1f;
    
    
    
    
    void Start()
    {

        player = GetComponent<Player>();
        
    }

   
    void Update()
    {
        animator.SetBool("Andando", player.andando);
        animator.speed = animation_velocity;
    }
}
