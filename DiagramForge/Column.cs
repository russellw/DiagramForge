﻿using SkiaSharp;

namespace DiagramForge;
public sealed class Column: Window {
	public List<Window> contents = new();

	public override void Draw(SKCanvas canvas) {
		foreach (var window in contents)
			window.Draw(canvas);
	}

	public override void SetSize() {
		float width = 0;
		float height = 0;
		foreach (var window in contents) {
			window.SetSize();
			width = Math.Max(width, window.size.Width);
			height += window.size.Height;
		}
		size.Width = width;
		size.Height = height;
	}
}