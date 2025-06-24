using UnityEngine;

public class TestePersonagem : MonoBehaviour
{
    void Start()
    {
     
        Personagem guerreiro = new GameObject("Guerreiro").AddComponent<Personagem>();
        guerreiro.nome = "Thorin";
        guerreiro.nivel = 5;
        guerreiro.vida = 100f;
        guerreiro.forca = 20f;

        Monge monge = new GameObject("Monge").AddComponent<Monge>();
        monge.nome = "Shen";
        monge.nivel = 7;
        monge.vida = 120f;
        monge.forca = 30f;

        
        Debug.Log("Guerreiro: " + guerreiro.nome + ", Força: " + guerreiro.forca);
        Debug.Log("Monge: " + monge.nome + ", Força: " + monge.forca);

        Debug.Log(guerreiro.CompararForca(monge));

        monge.UsarHabilidade();
    }
}