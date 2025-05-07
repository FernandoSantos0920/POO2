using UnityEngine;

public class Inimigo : Personagem
{
    [SerializeField]
    private ArmaduraDoInimigo armadura;
    [SerializeField]
    private ArmaDoInimigo arma;

    


    public enum ArmaDoInimigo   
    {
        ESPADA, MACHADO, GARRAS
    }
    
    
    public enum ArmaduraDoInimigo
    {
       MADEIRA, COURO, AÇO, OURO
    }
    
    
    
    
    public void MudarArmadura(ArmaduraDoInimigo armadura)
    {
        this.armadura = armadura;
    }
    
    
    public ArmaduraDoInimigo Armadura()
    {
        return this.armadura;
    }

    
    public void MudarArma(ArmaDoInimigo arma)
    {
        this.arma = arma;
    }

    public ArmaDoInimigo Arma()
    {
        return this.arma;
    }
    
    
    
    
    public int DanoDoInimigo()
    {
        int dano = 0;
        switch (arma)
        {
            case ArmaDoInimigo.ESPADA:
                dano = (int)Forca_ataqueDoPersonagem() + 10;
                break;
                
            case ArmaDoInimigo.MACHADO:
                dano = (int)Forca_ataqueDoPersonagem() + 15 ;
                break;
                
            case ArmaDoInimigo.GARRAS:
                dano = (int)Forca_ataqueDoPersonagem() + 8;
                break;
        }
            return dano;
    }
    
    
    
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
}