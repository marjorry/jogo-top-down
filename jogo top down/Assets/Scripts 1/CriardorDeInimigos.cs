using UnityEngine;

public class CriarInimigos : MonoBehaviour
{
   public GameObject[] inimigos;
   public Transform[] posicaodosInimigos;
   
   public float tempoDoInimigo = 15; //segundos
   
   private float conometroDoInimigo = 0;
   
   
   
    void Start()
    {
        
    }

 
    void Update()
    {
        conometroDoInimigo += Time.deltaTime;
        if (conometroDoInimigo >= tempoDoInimigo)
        {
            Transform ponto = posicaodosInimigos[Random.Range(0, posicaodosInimigos.Length)];
            
            GameObject inm = Instantiate(inimigos[Random.Range(0, inimigos.Length)],
            new Vector3( ponto.position.x, ponto.position.y, ponto.position.z),
            ponto.rotation) as GameObject;
            
        }
    }
}
