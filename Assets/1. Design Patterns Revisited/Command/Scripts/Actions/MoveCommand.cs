using UnityEngine;

public class MoveCommand : Command
{
   private readonly SquareController _square;
   private readonly Vector2 _direction;

   public MoveCommand(SquareController square, Vector2 direction) {
      _square = square;
      _direction = direction;
   }

   public override void Execute() {
      _square.Move(_direction);
   }

   public override void Undo() {
      _square.Move(getOppositeDirection(_direction));
   }

   private Vector2 getOppositeDirection(Vector2 direction) {
      return new Vector2(direction.x * -1, direction.y * -1);
   }
}