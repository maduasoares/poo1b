using UnityEngine;

public class Monge : Personagem
{
    public string estiloDeLuta = "Artes Marciais";
    public string habilidadeEspecial = "Soco de Dragão";

    public void UsarHabilidade()
    {
        Debug.Log(nome + " usou " + habilidadeEspecial + "!");
    }
}