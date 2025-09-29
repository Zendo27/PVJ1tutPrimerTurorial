using UnityEngine;

public class MovimientoAcelerado : IMovementStrategy
{
    private float velocidadActual = 0f;

    public void Move(Transform transform, Player player)
    {
        velocidadActual += Input.GetAxis("Horizontal") * player.Aceleracion * Time.deltaTime;
        velocidadActual = Mathf.Clamp(velocidadActual, -player.Velocidad, player.Velocidad);
        transform.Translate(velocidadActual * Time.deltaTime,0,0);
    }
}
