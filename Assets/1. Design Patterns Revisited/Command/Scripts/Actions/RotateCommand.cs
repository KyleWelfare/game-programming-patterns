public class RotateCommand : Command
{
   private readonly SquareController _square;

   public RotateCommand(SquareController square) {
      _square = square;
   }

   public override void Execute() {
      _square.Rotate(1);
   }

   public override void Undo() {
      _square.Rotate(-1);
   }
}