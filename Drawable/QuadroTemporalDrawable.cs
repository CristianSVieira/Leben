using Leben.Controls;

namespace Leben.Drawable;

public class QuadroTemporalDrawable : IDrawable {
    private readonly QuadroTemporalControl _quadroTemporalControl;
    public QuadroTemporalDrawable(QuadroTemporalControl quadroTemporalControl) {
        _quadroTemporalControl = quadroTemporalControl;
    }

    public void Draw(ICanvas canvas, RectF dirtyRect) {
        canvas.SaveState();
        canvas.FillColor = Colors.DarkBlue;
        canvas.FillRectangle(10, 10, 100, 50);
        canvas.RestoreState();
    }
}