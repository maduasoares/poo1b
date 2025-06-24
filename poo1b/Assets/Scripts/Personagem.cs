using UnityEngine;

public class Personagem : MonoBehaviour
{
public string nome;
public int nivel;
public float vida;
public float forca;

public string CompararForca(Personagem outro)
{
if (forca > outro.forca)
{
return nome + " é mais forte que " + outro.nome;
}
else if (forca < outro.forca)
{
return outro.nome + " é mais forte que " + nome;
}
else
{
return nome + " e " + outro.nome + " têm a mesma força.";
}
}
}