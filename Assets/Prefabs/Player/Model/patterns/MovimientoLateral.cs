using UnityEngine;

public class MovimientoLateral : IMovementStrategy
{
    public void Move(Transform transform, Player player, float direction)
    {
        float moveInX = direction * player.Velocidad * Time.deltaTime;
        transform.Translate(moveInX, 0, 0);

        //float direccion = Input.GetAxis("Horizontal");
        //transform.Translate(direccion * player.Velocidad * Time.deltaTime, 0, 0);
    }
}
