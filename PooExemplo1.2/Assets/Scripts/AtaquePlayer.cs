using UnityEngine;

public class AtaquePlayer : MonoBehaviour
{
    public Personagem personagem;
    private int ataque;
    

    public int AtaqueDoPersonagem()
    {
        ataque = (int)personagem.Forca_ataqueDoPersonagem(); 
        return ataque;
    }
}