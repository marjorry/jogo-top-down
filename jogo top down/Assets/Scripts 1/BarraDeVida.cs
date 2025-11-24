using UnityEngine;
using UnityEngine.UI;
public class BarraDeVida : MonoBehaviour
{
    public Slider sliderVidasReestantes;
    
    public Personagem personagem;
    [SerializeField] private int vidasRestantes = 0;
    void Start()
    {
        if (personagem != null & sliderVidasReestantes != null)
        {
            sliderVidasReestantes.minValue = 0;
            sliderVidasReestantes.maxValue = personagem.getVida();
        } 
    }


    void Update()
    {
        if (sliderVidasReestantes != null)
        {
            
            vidasRestantes = personagem.getVida();
            sliderVidasReestantes.value = vidasRestantes; 
        }
    
    
    
    
        
    }
}