using System;
using UnityEngine;

public class Dano : MonoBehaviour
{
    private Personagem personagem;

    private void OnCollisionEnter2D(Collision2D colisao)
    {

        if (colisao.gameObject.CompareTag("Inimigo"))
        {
            int energia_atual = personagem.EnergiaDoPersonagem()
                               - colisao.gameObject.GetComponent<Inimigo>().DanoDoInimigo();


            personagem.MudarEnergia(energia_atual);

            Debug.Log("O personagem " +personagem.NomeDoPersonagem()+ " Tem agora " + personagem.EnergiaDoPersonagem() + " De energia");

        }
        
        
        
    }
    
     void Start()
     {
         personagem = GetComponent<Personagem>();
         
     }
    
    void Update()
    {
        
    }
}