using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Jogador : Personagem
{
 
    void Start()
    {
        
    }

   
    void Update()
    {
       
        if (Input.GetKey(KeyCode.D)) //Esquerda
        {
            transform.position += new Vector3(getvelocidade()*Time.deltaTime, 0, 0);
        }
        
        if (Input.GetKey(KeyCode.A)) //Direita
        {
            transform.position -= new Vector3(getvelocidade()*Time.deltaTime, 0, 0);
        }
        
        if (Input.GetKey(KeyCode.W)) //Cima
        {
            transform.position += new Vector3(0, getvelocidade()*Time.deltaTime, 0);
        }
        
        if (Input.GetKey(KeyCode.S)) //Baixo
        {
            transform.position -= new Vector3(0, getvelocidade()*Time.deltaTime, 0);
        }
        
    }

    
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Inimigo")
        {
            int vidas = getVidas() - 1;
                setVidas(vidas);
        }
    }
    
    
    
    
    
}
