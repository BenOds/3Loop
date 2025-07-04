using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    [Header("GameObjects Assignments")]
    public GameObject nosePrefab;
    public Transform noseSpawnPosition;


    BoxCollider shadow;

    [Header("Collision off gate")]
    public float shadowtime;

    [Header("Direction Force")]
    public int noseBulletForce;
    public float noseBulletDirectionZ;
    public float noseBulletDirectionY;

    [Header("Ammo")]
    public int noseBullet;
    public int namePosittionArray;
    public int counting;

    int reload;
    // noseBulletNameArray: Array para las balas
    public string[] noseBulletNameArray;

    string rename;


    GameObject noseClonePrefab;
    GameObject noseBorn;

    // Collider
    // bool controlName;
    BoxCollider noseControlCollider;

    // PrefabDeath accessPrefabDeath;
    // bool controlName = accessPrefab.controlName;

    GameObject controlBall;
    Collider ball;

    // -------------- Inicializers ---------------------

    void Start()
    {
        namePosittionArray = 0;
        noseBulletNameArray = new string[6];
        noseControlCollider = gameObject.GetComponent<BoxCollider>();
        Ammo();
    }

    void Update()
    {
        counting = noseBullet + namePosittionArray;
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
        if (Input.GetMouseButtonDown(0))
        {
            Attack();
        }
    }

    void InputPad()
    {

    }

    // ---------------------- MÉTODOS ---------------------

    /* Attack
    Método para cuando queramos lanzar una "nariz"
    Instanciamos el prefab "nose prefab"
    Llamamos al método Naming para adjudicar nombre al prefab generado del array
    Restamos en el contador de "noseBullet" cada vez que generamos un prefab
    Cambiamos el tag del prefab generado. De "noseBorn" a "nose"
    Borramos el nombre que hemos adjudicado al prefab del array 
    */
    void Attack()
    {
        if (noseBullet > 0)
        {
            // Insanciar prefab de la nariz a disparar
            noseClonePrefab = Instantiate(nosePrefab, noseSpawnPosition.position, noseSpawnPosition.rotation);
            // se le asigna al rpefab generado un rigidbody y aplicarle "fuerza" (dirección)
            noseClonePrefab.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, noseBulletDirectionY, noseBulletDirectionZ) * noseBulletForce);
            // Cambiar el nombre del "nose prefab" cuando se genera por uno de los que se ha escogido. 
            noseClonePrefab.name = noseBulletNameArray[noseBullet - 1];
            noseBullet--;

            Invoke("TagChange", shadowtime);
            Erase();
        }
    }

    // ---------------------- AMMO ---------------------

    bool Control()
    {
        return true;
    }

    /* OnCollissionEnter
    Detector de collision con nose prefab para "recolectar"
    Aprovechamos para identificar el nombre que tiene adjudicado para listarlo en el array
    Renombramos la ubicación del array con el nombre del prefab que hemos recolectado.
    */
    void OnCollisionEnter(Collision noseBulletCollision)
    {
        // hay que añadir aquí el boleano
        if (noseBulletCollision.collider.CompareTag("Ball") && noseControlCollider.enabled == true)
        {
            rename = noseBulletCollision.gameObject.name;
            Debug.Log("Recogiendo " + rename);
            noseBulletNameArray[counting] = rename;
        }
    }

    // Los nombres de las narices en el array.
    void Ammo()
    {
        noseBulletNameArray[0] = "Sherif";
        noseBulletNameArray[1] = "Tabern";
        noseBulletNameArray[2] = "Train Driver";
        noseBulletNameArray[3] = "Gold Miner";
        noseBulletNameArray[4] = "Indian";
        noseBulletNameArray[5] = "Mexican";
    }

    // Para cambiar el nombre del "nose prefab" 
    // cuando se genera por uno de los que se ha escogido.
    void Naming()
    {
        // se ha trasladado dentro del método Attack
        // noseClone.name = noseBulletNameArray[noseBullet-1];
    }

    // Para cambiar el nombre en el array, por el del "nose prefab"
    // que hemos recolectado en la ubicación que indicamos.
    public void Renaming()
    {
        // se ha trasladado dentro del método OnCollisionEnter
        // noseBulletNameArray[counting] = rename;
        // controlName = true;
    }

    // Indicamos que la celda del array queda vacía cuando se usa
    // lo identificamos con EMPTY
    void Erase()
    {
        noseBulletNameArray[noseBullet] = "EMPTY";
    }

    //  Input para comprobar por consola el orden de los nombres. 
    void AmmoCheck()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (noseBullet > 0)
            {
                for (int i = (noseBullet - 1); i >= 0; i--)
                {
                    Debug.Log("bala " + (noseBulletNameArray[i]) + (" cargada"));
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
            noseBullet = namePosittionArray + noseBullet;
            namePosittionArray = 0;
            Debug.Log("Recarga");
        }
    }

    /* TagChange
    Cambio de tag para el "nose prefab" que de origen es "noseBorn" 
    y lo cambiamos por "nose"
    Esto se hace para que cuando identifiquemos el prefab recién generado y activemos su collider
    no haya conflicto con posibles prefabs generados anteriormente.
    Lo mismo sirve para cambiarles el nombre.
    */
    void TagChange()
    {
        noseBorn = GameObject.FindGameObjectWithTag("noseBorn");
        noseBorn.GetComponent<SphereCollider>().enabled = true;
        noseBorn.tag = "Ball";

        Debug.Log("nariz disparada");

    }
}
