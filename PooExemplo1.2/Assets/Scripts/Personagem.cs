using System.Collections;

using UnityEngine;

public class Personagem : MonoBehaviour
{

    [SerializeField]
    private string nome;
    [SerializeField]   
    private int energia;
    [SerializeField]
    private float forca_ataque;
    [SerializeField] 
    private float forca_do_pulo;
    [SerializeField]
    private int velocidade;
    [SerializeField]
    private int numero_de_pes;
    [SerializeField]
    private int numero_de_maos;
  
   
   
  
        //Nome//
        public void AqueleNome(string nome)
        {
            this.nome = nome;
        }

        public string NomeDoPersonagem()
        {
            return this.nome;
        }

       
        
        
        //Energia//
        public void MudarEnergia(int energia)
        {
            this.energia = energia;
        }

        public int EnergiaDoPersonagem()
        {
            return this.energia;
        }


       
        
        //Força do Ataque//
        public void MudarForcaDoAtaque(float forca_ataque)
        {
            this.forca_ataque = forca_ataque;
        }

        public float Forca_ataqueDoPersonagem()
        {
            return this.forca_ataque;
        }


       
        //Força do Pulo//
        public void MudarForcaDoPulo(float forca_do_pulo)
        {
            this.forca_do_pulo = forca_do_pulo;
        }

        public float Forca_do_puloDoPersonagem()
        {
            return this.forca_do_pulo;
        }

        
        //Velocidade//
        public void MudarVelocidade(int velocidade)
        {
            this.velocidade = velocidade;
        }

        public int VelocidadeDoPersonagem()
        {
            return this.velocidade;
        }


        //Pés//
        public void MudarNumeroDePes(int numero_de_pes)
        {
            this.numero_de_pes = numero_de_pes;
        }

        public int NumeroDePesDoPersonagem()
        {
            return this.numero_de_pes;
        }


        
        //Mãos//
        public void MudarNumeroDeMaos(int numero_de_maos)
        {
            this.numero_de_maos = numero_de_maos;
        }

        public int NumeroDeMaosDoPersonagem()
        {
            return this.numero_de_maos;
        }



      
     
    // Update is called once per frame
    void Update()
    {
        
    }
 }