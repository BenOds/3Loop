using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Taximeter : MonoBehaviour
{
    // tiempo invertido en su servicio (en minutos)
    // servicios menjos o igulas a 30 min, el importe es fijo 40€
    // después de los 30 min se aplicará una tarrifa de 2€ por minuto

    public int tiempoServicio;
    int tarifa;
    public int tarifabase = 40;
    public int tarifaXminutos = 2;
    void Start()
    {
        Textoinformativo();
        TiempoServicio();
        Tarifa();
    }

    void Update()
    {
        
    }

    int TiempoServicio()
    {
        tiempoServicio = Random.Range(1,200);
        Debug.Log("La duración del servicio ha sido de " +tiempoServicio + " minutos.");
        return tiempoServicio;
    }

    int Tarifa()
    {
        if (tiempoServicio<= 30)
        {
            tarifa = tarifabase;
            Debug.Log("El servicio no supera los 30 minutos, se aplcia la tarifa mínima de 30€");
        }
        else
        {
            tarifa = (tiempoServicio - 30) * tarifaXminutos + tarifabase;
            Debug.Log("La tarifa del servicio será de " +tarifa + " euros");
            TarifaMayor();
        }
        return tarifa;
    }
    string TarifaMayor()
    {
        int diferencia = tarifa - tarifabase;
        Debug.Log("40€ iniciales por la tarifa base de los primeros 30 minutos de servicio"); 
        Debug.Log("Mas los " +diferencia + " Euros de los " +(tiempoServicio-30) +" minutos restantes");
        return "yoyo";
    }

    void Textoinformativo()
    {
        Debug.Log("La Tarifa del taxi:");
        Debug.Log("Bajada de bandera - > 40€");
        Debug.Log("A partir de los 30 minutos - > 2€ por minuto");
    }

}
