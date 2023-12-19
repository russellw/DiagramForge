using SkiaSharp;

class Program {
	static void Main(string[] _) {
		int width = 200;
		int height = 100;
		var bitmap = new SKBitmap(width, height);
		using var canvas = new SKCanvas(bitmap);
		string[] parts = { "int", " ", "x" };
		var paint = new SKPaint { TextSize = 12, Color = SKColors.Black };
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
