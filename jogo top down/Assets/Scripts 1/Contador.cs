using UnityEngine;

public class Contador : MonoBehaviour
{
    public int pontos;
    public TMPro.TextMeshProUGUI texto;
    void Start()
    {
        
    }

  
    void Update()
    {
        texto.text = pontos.ToString();
    }
}
