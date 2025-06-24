using UnityEngine;

public class TesteDano : MonoBehaviour
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

       
        Debug.Log("Vida antes do ataque:");
        Debug.Log(guerreiro.nome + ": " + guerreiro.vida);
        Debug.Log(monge.nome + ": " + monge.vida);

        
        float danoDoGuerreiro = guerreiro.forca;
        monge.vida -= danoDoGuerreiro;
        Debug.Log(guerreiro.nome + " atacou " + monge.nome + " e causou " + danoDoGuerreiro + " de dano!");

       
        float danoDoMonge = monge.forca;
        guerreiro.vida -= danoDoMonge;
        Debug.Log(monge.nome + " atacou " + guerreiro.nome + " e causou " + danoDoMonge + " de dano!");

        
        Debug.Log("Vida depois do ataque:");
        Debug.Log(guerreiro.nome + ": " + guerreiro.vida);
        Debug.Log(monge.nome + ": " + monge.vida);
    }
}