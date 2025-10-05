using UnityEngine;

public class MovimientoAcelerado : IMovementStrategy
{
    //private float velocidadActual = 0f;

    public void Move(Transform transform, Player player, float direction)
    {
        float movement = direction * (player.Velocidad + player.Aceleracion)* Time.deltaTime;
        transform.Translate(movement * Time.deltaTime, 0, 0);

        //velocidadActual += Input.GetAxis("Horizontal") * player.Aceleracion * Time.deltaTime;
        //velocidadActual = Mathf.Clamp(velocidadActual, -player.Velocidad, player.Velocidad);
        //transform.Translate(velocidadActual * Time.deltaTime, 0, 0);
    }
}
