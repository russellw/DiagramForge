namespace DiagramForge;
public sealed class Column: MultiContainer {
	public override void SetPosition(float x, float y) {
		base.SetPosition(x, y);
		foreach (var window in contents) {
			window.SetPosition(x, y);
			y += window.height;
		}
	}

	public override void SetSize() {
		width = 0;
		height = 0;
		foreach (var window in contents) {
			window.SetSize();
			width = Math.Max(width, window.width);
			height += window.height;
		}
	}
}
