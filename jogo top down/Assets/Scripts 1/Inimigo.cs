using UnityEngine;

public class Inimigo : Personagem
{
    private GameObject contador;
    public int pontos = 1;
    
    [SerializeField] private int dano = 1;
    
    public float raioDeVisao = 1;
    public CircleCollider2D _visaoCollider2D;

    [SerializeField] private Transform posicaoDoPlayer;
    
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    public AudioSource AudioSource;

    private bool andando = false;
    
    public void setDano(int dano)
    {
        this.dano = dano;
    }
    public int getDano()
    {
        return this.dano;
    }
    
    
    
    void Start()
    {
        contador = GameObject.Find("Contador");
        
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        
        if (posicaoDoPlayer == null)
        {
            posicaoDoPlayer =  GameObject.Find("Player").transform;
           // posicaoDoPlayer =  GameObject.FindGameObjectsWithTag("Player")[0].transform;
        }
        
        raioDeVisao = _visaoCollider2D.radius;
        
        AudioSource = GetComponent<AudioSource>();
        
        
        
        

    }

    void Update()
    {
        andando = false;

        if (getVida() > 0)
        {

            if (posicaoDoPlayer.position.x - transform.position.x > 0)
            {
                spriteRenderer.flipX = false;
            }

            if (posicaoDoPlayer.position.x - transform.position.x < 0)
            {
                spriteRenderer.flipX = true;
            }


            if (posicaoDoPlayer != null &&
                Vector3.Distance(posicaoDoPlayer.position, transform.position) <= raioDeVisao)
            {
                Debug.Log("Posição do Pluer" + posicaoDoPlayer.position);

                transform.position = Vector3.MoveTowards(transform.position,
                    posicaoDoPlayer.transform.position,
                    getVelocidade() * Time.deltaTime);

                andando = true;
            }

        }
        
        if (getVida() <= 0)
        {
            animator.SetTrigger( name:"Morte");
        }

        animator.SetBool(name:"Andando", andando);
    }

    
    
    
    public void desative()
    {
        gameObject.SetActive(false);
    }

    public void playAudio()
    {
        AudioSource.Play();
    }
    
   private void onCollisionEnter2D(Collision2D collision)
   {
       if (collision.gameObject.CompareTag("Player") && getVida()>0)     
       {
        //causa dano no player
        int novaVida =collision.gameObject.GetComponent<Personagem>().getVida();
        collision.gameObject.GetComponent<Personagem>().setVida(novaVida);
        
        // zera a vida do Inimigo
        setVida(0);
        
       }
    
    
    }

    public void desativa()
    {
        contador.GetComponent<Contador>().pontos += pontos;
        
        //desativa o objeto do Inimigo
        //gameObject.SetActive(false);
        Destroy(gameObject);
        Debug.Log("Teste...");
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && getVida() > 0)
        {
            // Causa dano ao Player
            int novaVida = collision.gameObject.GetComponent<Personagem>().getVida() - getDano();
            collision.gameObject.GetComponent<Personagem>(). setVida(novaVida);

            //collision.gameObject.GetComponent<Personagem>().recebeDano(getDano());
            
            //sera a vida do inimigo
            setVida(0);
          
        }
    }

}