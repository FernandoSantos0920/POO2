using System;
using System.ComponentModel;
using UnityEngine;

public class Teste2 : MonoBehaviour
{

    public void Mensagem(string mensagem)
    {
        Debug.Log(mensagem); 
        return;
    }


    public void IdadeDeUmaPessoa(string nome, int idade)
    {
        Debug.Log("A pessoa tem nome " + nome +" e uma idade de: " + idade);
        return;
        string frase = "A pessoa tem" + nome + " e uma idade de:" + idade;
       
        Mensagem(frase);

    }
    
    void Start()
    {
        IdadeDeUmaPessoa("Pablito", 10);
        IdadeDeUmaPessoa("Cassino", 10);
        IdadeDeUmaPessoa("Pinga", 10);
        IdadeDeUmaPessoa("Blank", 10);
    }

    
    void Update()
    {
        
    }
}