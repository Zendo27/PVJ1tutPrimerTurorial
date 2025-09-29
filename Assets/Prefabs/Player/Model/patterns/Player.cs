using UnityEngine;

public class Player
{
    private float velocidad = 0;
    private float aceleracion = 0;

    public Player(float velocidadActual, float aceleracion)
    {
        this.velocidad=velocidadActual;
        this.aceleracion = aceleracion;
    }

    public float Velocidad { get => velocidad; set => velocidad = value; }
    public float Aceleracion { get => aceleracion; set => aceleracion = value; }
}
