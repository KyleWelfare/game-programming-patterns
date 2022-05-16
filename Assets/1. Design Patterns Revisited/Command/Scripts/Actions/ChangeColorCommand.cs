using UnityEngine;

public class ChangeColorCommand : Command
{
   private readonly SquareController _square;
   private readonly Color _currentColor;
   private Color prevColor;

   public ChangeColorCommand(SquareController square, Color currentColor) {
      _square = square;
      _currentColor = currentColor;
   }

   public override void Execute() {
      prevColor = _currentColor;
      _square.ChangeColor(new Color(0, 0, 0, 0));
   }

   public override void Undo() {
      _square.ChangeColor(prevColor);
   }
}