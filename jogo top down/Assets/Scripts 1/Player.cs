using UnityEngine;

public class Player : Personagem1
{
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    
    public Transform arma;

    private bool amdando;
    
    void Start()
    {
     
    }
    void Update()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
           gameObject.transform.position += new Vector3(getVelocidade() * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.position -= new Vector3(getVelocidade() * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position += new Vector3(getVelocidade() * Time.deltaTime, 0, 0 );
        }
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position -= new Vector3(getVelocidade() * Time.deltaTime, 0, 0 );
        }
        
    }
}