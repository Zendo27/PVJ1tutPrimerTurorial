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
    /// <summary>
    /// indica la velocidad lateral
    /// </summary>
    //private float velocidadLateral;
    /// <summary>
    /// Representa la estrategia de movimiento
    /// </summary>
    private IMovementStrategy strategy;
    /// <summary>
    /// Representa la clase player
    /// </summary>}
    private Player player;
    #endregion

    #region Ciclo de vida del script
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() 
    {
        fuerzaPorAplicar = new Vector3(0, 0, 300f);
        tiempoDesdeUlitmaFuerza = 0f;
        intervaloTiempo = 2f;
        //velocidadLateral = 5f;
        player = new Player(5f, 5f);
        SetStrategy(new MovimientoAcelerado());

    }

    // Update is called once per frame
    public void MovePlayer(float input)
    {
        strategy.Move(transform, player, input);
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

    #region Logica del Script

    public void SetStrategy(IMovementStrategy strategy) 
    {
        this.strategy = strategy;
    }

    #endregion

}
