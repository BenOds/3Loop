using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    
    [Header("GameObjects Assignments")]
    public GameObject ballPrefab;
    public Transform SpawnBall;


    BoxCollider shadow;

    [Header("Collision off gate")]
    public float shadowtime;

    [Header("Direction Force")]
    public int Force;
    public float directionZ;
    public float directionY;

    [Header("Ammo")]
    public int balls;
    public int count;
    public int counting;

    int reload;
    public string[] ammo;

    string rename;
    

    GameObject cloneball;
    GameObject ballborn;

    // Collider
    // bool controlName;
    BoxCollider controlCollider;

    PrefabDeath accessPrefabDeath;
    bool controlName = accessPrefab.controlName;



    

// -------------- Inicializers ---------------------

    void Start()
    {
        count = 0;
        ammo = new string [6];
        controlCollider = gameObject.GetComponent<BoxCollider>();
        Ammo();     
    }

    void Update()
    {
        counting = balls+count;
        InputMouse();
        InputKey();
        InputPad();  
    }
// ---------------------- INPUTS ---------------------

    void InputKey()
    {
        Reload();
        AmmoCheck();
    }

    void InputMouse()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Attack();
        }
    }

    void InputPad()
    {

    }

// ---------------------- MÉTODOS ---------------------
 
// Método para cuando queramos lanzar una "nariz"
// Instanciamos el prefab "nose prefab"
// Llamamos al método Naming para adjudicar nombre al prefab generado del array
// Restamos en el contador de "balls" cada vez que generamos un prefab
// Cambiamos el tag del prefab generado. De "ballBorn" a "ball"
// Borramos el nombre que hemos adjudicado al prefab del array

    void Attack()
    {
        if (balls > 0 )
        {
        cloneball = Instantiate(ballPrefab, SpawnBall.position, SpawnBall.rotation);
        cloneball.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0,directionY,directionZ) * Force);  
        Naming();
        balls--;
        
        Invoke("TagChange",shadowtime);
        Erase();
        } 
    }

// ---------------------- AMMO ---------------------

bool Control()
{
     
    return true;
}

// Detector de collision con nose prefab para "recolectar"
// Aprovechamos para identificar el nombre que tiene adjudicado para listarlo en el array
// Renombramos la ubicación del array con el nombre del prefab que hemos recolectado.
    void OnCollisionEnter (Collision collisionBullet)
    {
        if(collisionBullet.collider.CompareTag("Ball") && controlCollider.enabled == true) // hay que añadir aquí el boleano
        {
            controlCollider.enabled = false;
            rename = collisionBullet.gameObject.name;
            Debug.Log("Recogiendo "+ rename);
            Renaming();

        }
    }

// Los nombres de las narices en el array.
    void Ammo()
    {
        ammo[0] = "Sherif";
        ammo[1] = "Tabern";
        ammo[2] = "Train Driver";
        ammo[3] = "Gold Miner";
        ammo[4] = "Indian";
        ammo[5] = "Mexican";            
    }

// Para cambiar el nombre del "nose prefab" cuando se genera por uno de los que se ha escogido.
    void Naming()
    { 
        cloneball.name = ammo[balls-1];
    }

// Para cambiar el nombre en el array, por el del "nose prefab" que hemos recolectado
    // en la ubicación que indicamos.
    public void Renaming()
    {
        ammo[counting] = rename;
        //controlName = true;

    }

//  Borra los nombres en el Array a medida que el prefab "nose Prefab" se genera
    void Erase()
    {
        ammo[balls] = "";
    }
 
//  Input para comprobar por consola el orden de los nombres. 
    void AmmoCheck()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {   
            if (balls > 0)
            {
                for(int i = (balls-1); i >= 0 ; i--)
                {
                Debug.Log(ammo[i]);
                }
            }
            else
            {
                Debug.Log("No hay narices");
            }
        }
    }

// Input para "recargar" con "nose prefab" que se ha ido recolectando.
    public void Reload()
    {
      
            if (Input.GetKeyDown(KeyCode.R))
        {
            balls = count + balls;
            count = 0;
        }
    }

// Cambio de tag para el nose prefab que de origen es "ballBorn" y lo cambiamos por "ball"
// Esto se hace para que cuando identifiquemos el prefab recién generado y activemos su collider
    // no haya conflicto con posibles prefabs generados anteriormente.
// Lo mismo sirve para cambiarles el nombre.
    void TagChange()
    {
        ballborn = GameObject.FindGameObjectWithTag("BallBorn");
        ballborn.GetComponent<SphereCollider>().enabled = true;
        ballborn.tag = "Ball";
        
        Debug.Log("nariz disparada");
    }
}
