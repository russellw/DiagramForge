namespace DiagramForge;
public sealed class Row: MultiContainer {
	public override void SetPosition(float x, float y) {
		base.SetPosition(x, y);
		foreach (var window in contents) {
			window.SetPosition(x, y);
			x += window.width;
		}
	}

	public override void SetSize() {
		width = 0;
		height = 0;
		foreach (var window in contents) {
			window.SetSize();
			width += window.width;
			height = Math.Max(height, window.height);
		}
	}
}
