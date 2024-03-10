using Leben.Controls;
using Leben.Models;

using System.Collections;

namespace Leben.Drawables;

public class QuadroTemporalDrawable : IDrawable {
    private readonly QuadroTemporalControl _quadroTemporalControl;
    private readonly List<QuadroTemporalModel> _quadroTemporalModel;

    float totalDeElementos = 1;
    int linhas = 1;
    int columnas = 1;

    public QuadroTemporalDrawable(QuadroTemporalControl quadroTemporalControl, List<QuadroTemporalModel> quadroTemporalModel) {
        _quadroTemporalControl = quadroTemporalControl;
        _quadroTemporalModel = quadroTemporalModel;

        totalDeElementos = _quadroTemporalModel.Count;

        columnas = (int) Math.Floor(totalDeElementos / 2);
        linhas = (int) Math.Ceiling(totalDeElementos / 2);
    }

    public void Draw(ICanvas canvas, RectF dirtyRect) {
        canvas.SaveState();

        for (int i = 0; i <= columnas; i++) {
            canvas.FillColor = _quadroTemporalModel[i].Côr;
            canvas.FillRectangle(
                100 * i,
                0,
                100 / columnas,
                100 / columnas
            );
        }

        //canvas.FillRectangle(50, 50, 100, 100);

        canvas.RestoreState();
    }
}
