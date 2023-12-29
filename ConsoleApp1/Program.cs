using SkiaSharp;

class Program {
	static void Main(string[] _) {
		var width = 200;
		var height = 100;
		using var bitmap = new SKBitmap(width, height);
		using var canvas = new SKCanvas(bitmap);
		string[] parts = { "int", " ", "x" };
		using var paint = new SKPaint { TextSize = 12, Color = SKColors.Black };
		var position = new SKPoint(10, 10);
		SKColor[] colors = { SKColors.Blue, SKColors.Black, SKColors.White };
		for (int i = 0; i < parts.Length; i++) {
			paint.Color = colors[i];
			canvas.DrawText(parts[i], position.X, position.Y, paint);
			position.X += paint.MeasureText(parts[i]);
		}
		Console.WriteLine(position);
	}
}
