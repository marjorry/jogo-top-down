using UnityEngine;

public class Personagem : MonoBehaviour
{
    [SerializeField]
    private int vidas;
    [SerializeField]
    private int energia;
    [SerializeField]
    private float velocidade;

    public void setVidas(int vidas)
    {
        this.vidas = vidas;
    }

    public int getVidas()
    {
        return vidas;
    }

    public void setenergia(int energia)
    {
        this.energia = energia;
    }

    public int getenergia()
    {
        return energia;
    }
    
    public void setvelocidade(float velocidade)
    {
        this.velocidade = velocidade;
    }

    public float getvelocidade()
    {
        return velocidade;
    }
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
}
