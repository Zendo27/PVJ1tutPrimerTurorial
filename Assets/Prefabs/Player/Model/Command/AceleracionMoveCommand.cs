using UnityEngine;

public class AceleracionMoveCommand : ICommand
{
    private readonly PlayerMovement playerMovement;
    private readonly float input;

    public AceleracionMoveCommand(PlayerMovement playerMovement, float input)
    {
    
        this.playerMovement = playerMovement;
        this.input = input; 
    }
    public void Execute()
    {
        playerMovement.SetStrategy(new MovimientoAcelerado());
        playerMovement.MovePlayer(input);
    }
}
