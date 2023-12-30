using SkiaSharp;

class Program {
	static void Main(string[] _) {
		var width = 1800;
		var height = 900;
		using var bitmap = new SKBitmap(width, height);
		using var canvas = new SKCanvas(bitmap);

		using var image = SKImage.FromBitmap(bitmap);
		using var data = image.Encode(SKEncodedImageFormat.Png, 100);
		using var stream = new FileStream("bin/a.png", FileMode.Create);
		data.SaveTo(stream);
	}
}
