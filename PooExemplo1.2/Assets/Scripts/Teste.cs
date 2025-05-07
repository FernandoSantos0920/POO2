using System;
using System.Collections.Generic;
using UnityEngine;

public class Teste : MonoBehaviour
{
   Carro fusca = new Carro(); 
   Personagem Tigrezo = new Personagem();
   Inimigo Virginia = new Inimigo();
   
   void Start()
    {
       
        /*
        fusca.MudarNome("Fusca zika");
       Debug.Log("O "+ fusca.NomeDoCarro());

       fusca.AtribuirCor("azul");
       Debug.Log("É " + fusca.CorDoCarro());
       
       fusca.MudarRodas(6);
       Debug.Log("Tem essa quantidade de rodas: " + fusca.NumeroDeRodas());
       
       
       fusca.MudarPreco(50000);
       Debug.Log("Custa em money: " + fusca.PrecoDoCarro());
       
        Debug.Log("O "+ fusca.NomeDoCarro() + " é " + fusca.CorDoCarro() + " tem " + fusca.NumeroDeRodas() + " rodas " + "e custa em real: " + fusca.PrecoDoCarro());

       */


        Tigrezo.AqueleNome("Tigrezo");
        Debug.Log("Seu nome é " + Tigrezo.NomeDoPersonagem());

        Tigrezo.MudarEnergia(5);
        Debug.Log("Tem " + Tigrezo.EnergiaDoPersonagem() + " De energia");

        Tigrezo.MudarForcaDoAtaque(9.5f);
        Debug.Log("Tem " + Tigrezo.Forca_ataqueDoPersonagem() + " De forca de ataque");

        Tigrezo.MudarForcaDoPulo(6.8f);
        Debug.Log("Tem " + Tigrezo.Forca_do_puloDoPersonagem() + " De forca de pulo");

        Tigrezo.MudarVelocidade(7);
        Debug.Log("Possui " + Tigrezo.VelocidadeDoPersonagem() + " De velocidade");
        
        Tigrezo.MudarNumeroDePes(2);
        Debug.Log("Tem " + Tigrezo.NumeroDePesDoPersonagem() + " pes");
        
        Tigrezo.MudarNumeroDeMaos(2);
        Debug.Log("Tem " + Tigrezo.NumeroDeMaosDoPersonagem() + " maos");
        

        Debug.Log("Seu nome é " + Tigrezo.NomeDoPersonagem() + " Tem " + Tigrezo.Forca_ataqueDoPersonagem() + " De forca de ataque " + "Tem " + Tigrezo.Forca_do_puloDoPersonagem() + " De forca de pulo" + "Possui " + Tigrezo.VelocidadeDoPersonagem() + " De velocidade" + "Tem " + Tigrezo.NumeroDePesDoPersonagem() + " pes" + "Tem " + Tigrezo.NumeroDeMaosDoPersonagem() + " maos");
        
        
        Virginia.AqueleNome("Virginia");
        Virginia.MudarEnergia(23);
        Virginia.MudarForcaDoAtaque(10f);
        Virginia.MudarForcaDoPulo (7f);
        Virginia.MudarVelocidade(12);
        Virginia.MudarNumeroDePes (2);
        Virginia.MudarNumeroDeMaos(2);
        Virginia.MudarArma(Inimigo.ArmaDoInimigo.MACHADO);
        Virginia.MudarArmadura(Inimigo.ArmaduraDoInimigo.COURO);

        if (Virginia.DanoDoInimigo() > Tigrezo.EnergiaDoPersonagem())
        {
            Debug.Log("O " + Tigrezo.NomeDoPersonagem() + " Ficou sem energia");
        }
        else
        {
            Debug.Log("O " + Tigrezo.NomeDoPersonagem() + " Ainda tem" + Tigrezo.EnergiaDoPersonagem() + " De energia");
        }
       
       
    }
     
    
    void Update()
    {
        
    }
    
}