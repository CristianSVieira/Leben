using Leben.Drawables;
using Leben.Models;

namespace Leben.Controls;

public partial class QuadroTemporalControl : ContentView {
    private QuadroTemporalDrawable _QuadroTemporalDrawable;

    public QuadroTemporalControl() {
        InitializeComponent();

        _QuadroTemporalDrawable = new QuadroTemporalDrawable(this, new List<QuadroTemporalModel>() {
            new QuadroTemporalModel() {
                Côr = Color.FromRgb(100, 100, 100),
            },
            new QuadroTemporalModel() {
                Côr = Color.FromRgb(100, 100, 100),
            }
        });

        Inicializar();
    }

    public void Inicializar()
    {
        QuadroView.Drawable = _QuadroTemporalDrawable;
    }
}
