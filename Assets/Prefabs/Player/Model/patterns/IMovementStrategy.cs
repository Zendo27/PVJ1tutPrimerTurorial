using UnityEngine;

public interface IMovementStrategy
{
    public void Move(Transform transform, Player player)
    {
    float moveInX = Input.GetAxis("Horizontal") * player.Velocidad * Time.deltaTime;
        transform.Translate(moveInX,0 ,0);
    }
}
