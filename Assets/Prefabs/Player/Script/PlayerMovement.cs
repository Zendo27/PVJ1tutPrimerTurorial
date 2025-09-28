using UnityEngine;
/// <summary>
/// Permite el comportamiento del movimiento del jugador
/// </summary>
public class PlayerMovement : MonoBehaviour
{
    #region Atributos
    /// <summary>
    /// fuerza utilizada para aplicar movimiento
    /// </summary>
    private Vector3 fuerzaPorAplicar;
    /// <summary>
    /// tiempo desde la ultima aplicacion de fuerza
    /// </summary>
    private float tiempoDesdeUlitmaFuerza;
    /// <summary>
    /// Indica cada cuanto tiempo debe aplicarse la fuerza
    /// </summary>
    private float intervaloTiempo;
    #endregion

    #region Ciclo de vida del script
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() 
    {
        fuerzaPorAplicar = new Vector3(0, 0, 300f);
        tiempoDesdeUlitmaFuerza = 0f;
        intervaloTiempo = 2f;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void FixedUpdate()
    {
        tiempoDesdeUlitmaFuerza += Time.fixedDeltaTime;
        if (tiempoDesdeUlitmaFuerza >= intervaloTiempo)
        {
            GetComponent<Rigidbody>().AddForce(fuerzaPorAplicar);
            tiempoDesdeUlitmaFuerza = 0f;
        }
    }
    #endregion
}
