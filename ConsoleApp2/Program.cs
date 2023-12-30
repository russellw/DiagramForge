using DiagramForge;
using SkiaSharp;

class Program {
	static void Main(string[] _) {
		var text = new Text("foo");
		text.color = new SKColor(0xff, 0xff, 0xff);
		Console.WriteLine(text.position);

		using var bitmap = new SKBitmap(1800, 900);
		using var canvas = new SKCanvas(bitmap);
		text.Draw(canvas);
		var paint = new SKPaint();
		paint.Color = new SKColor(0x0, 0xff, 0x0);
		canvas.DrawRect(1, 1, 50, 50, paint);
		canvas.DrawText("flgrhh", 30, 100, paint);

		using var image = SKImage.FromBitmap(bitmap);
		using var data = image.Encode(SKEncodedImageFormat.Png, 100);
		using var stream = new FileStream("bin/a.png", FileMode.Create);
		data.SaveTo(stream);
	}
}
