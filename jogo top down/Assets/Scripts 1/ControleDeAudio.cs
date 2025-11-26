using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class ControleDeAudio : MonoBehaviour
{

    public AudioMixer mixer;
    
    public int volume;
    public int volumeEfeitosSonoros;
    public bool musica;


    public Slider volumeSlider;
    public Slider volumeEfeitosSonoroslider;
    public Toggle toggleMusica;
    public TMP_Text textoMusica;
    void Start()
    {
        musica = toggleMusica.isOn;
        volume = (int)volumeSlider.value;
        volumeEfeitosSonoros = (int) volumeEfeitosSonoroslider.value;
    }

    
    void Update()
    {
        musica = toggleMusica.isOn;
        volume = (int)volumeSlider.value;
        volumeEfeitosSonoros = (int) volumeEfeitosSonoroslider.value;

        if (musica == true)
        {
            textoMusica.text = "Ligado";
            textoMusica.color = Color.green;
            
        }
        else 
        {
            textoMusica.text = "Desligado";
            textoMusica.color = Color.red;
        }

        if (volume <= -20)
        {
            volume = 80;
        }
        mixer.SetFloat("Master", volume);
    }
}
