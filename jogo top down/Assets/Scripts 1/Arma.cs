<<<<<<< HEAD
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows.WebCam;

public class Arma : MonoBehaviour
{
    public Transform saidaDoTiro;
    public GameObject bala;
    public float intervaloDoDisparo = 0.2f;
    private float tempoDeDisparo = 0;
    private Camera camera;
    public GameObject cursor;
    
    private SpriteRenderer spriteRenderer; 
    
   
    void Start()
    {
        camera = GetComponent<Camera>();
     spriteRenderer = GetComponent<SpriteRenderer>();
    
=======
using UnityEngine;
using UnityEngine.UIElements;

public class Arma : MonoBehaviour
{

    public Transform saidaDoTiro;
    
    public GameObject bala;
    
    public float intervaloDoDisparo = 0.2f;

    private float tempoDoDisparo = 0;
    
    private Camera camera;
    public GameObject cursor;
    
    private SpriteRenderer spriteRenderer;
    
    void Start()
    {
    camera = GetComponent<Camera>();
    spriteRenderer = GetComponent<SpriteRenderer>();
>>>>>>> a0b58c6933fc4768dd6580440423b27feaef7209
    }

    
    void Update()
    {
<<<<<<< HEAD
        if(gameObject.transform.rotation.eulerAngles.z > -90 && gameObject.transform.rotation.eulerAngles.z < 90)
        {
            transform.localScale = new Vector3(1 , 1, 1);
        }    
            
        if(gameObject.transform.rotation.eulerAngles.z > 90 && gameObject.transform.rotation.eulerAngles.z < 270)
        {
            transform.localScale = new Vector3( 1 , -1, 1);
        }    

        // Distância da câmera ao obejto. Precisamos disso para fazero cálculo correto.
        float camDis = camera.transform.position.y - transform.position.y;
        
        //Obtém a posição do mouse no espaço mundial. Usando comDis para o eixo Z.
       Vector3 mouse = camera.ScreenToWorldPoint(new Vector3 (Input.mousePosition.x, Input.mousePosition.y,camDis));

       float AnglePad = Mathf.Atan2(y: mouse.y - transform.position.y, mouse.x - transform.position.x);
       float angle = (180 / Mathf.PI) * AnglePad;
           
      transform.rotation = Quaternion.AngleAxis( angle, Vector3.forward);
      
      Debug.Log("Angilo: "+angle);
      
      cursor.transform.position=new Vector3(mouse.x,mouse.y,cursor.transform.position.z );
       
      Debug.DrawLine(transform.position, mouse, Color.red);

      if (tempoDeDisparo <= 0 && Input.GetKeyDown(KeyCode.Space))
      {
          Debug.Log("Bala disparada");
          
          GameObject b = Instantiate(this.bala, saidaDoTiro.position, saidaDoTiro.rotation) as GameObject;

          tempoDeDisparo = intervaloDoDisparo;

      }

      if (tempoDeDisparo > 0)
      {
          tempoDeDisparo -= Time.deltaTime;
      }
      
      
      
      
=======
        if (gameObject.transform.rotation.eulerAngles.z > -90 && gameObject.transform.rotation.eulerAngles.z < 90)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        
        if (gameObject.transform.rotation.eulerAngles.z > -90 && gameObject.transform.rotation.eulerAngles.z < 270)
        {
            transform.localScale = new Vector3(-1, -1, -1);
        }
        
        // Distância da câmera ao objeto. Precisamos disso para fazer o cálculo correto.
        float camDis = camera.transform.position.y -  transform.position.y;
        
        //Obtém a posição do mouse no espaço mundial. Usando camDis para o eixo Z.
        Vector3 mouse = camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,camDis));

        float AngleRad = Mathf.Atan2(mouse.y, mouse.x - transform.position.x);
        float angle = (180 / Mathf.PI) * AngleRad;
        
        transform.rotation = Quaternion.AngleAxis( angle, Vector3.forward);
        
       // Debug.Log("Angulo: " + angle);
        
        cursor.transform.position = new Vector3(mouse.x, mouse.y, cursor.transform.position.z);
        
        Debug.DrawLine(transform.position, mouse, Color.red);

        if (tempoDoDisparo > 0) ;






>>>>>>> a0b58c6933fc4768dd6580440423b27feaef7209
    }
}
