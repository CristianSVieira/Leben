using Leben.Drawables;
using Leben.Models;

namespace Leben.Controls;

public partial class QuadroTemporalControl : ContentView {
    private QuadroTemporalDrawable _QuadroTemporalDrawable;

    public QuadroTemporalControl() {
        InitializeComponent();

        _QuadroTemporalDrawable = new QuadroTemporalDrawable(this, new List<QuadroTemporalModel>() {
            new QuadroTemporalModel() {
                Côr = Color.FromRgb(200, 20, 10),
            },
            new QuadroTemporalModel() {
                Côr = Color.FromRgb(20, 10, 200),
            }
        });

        Inicializar();
    }

    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);
    }

    public void Inicializar()
    {
        QuadroView.Drawable = _QuadroTemporalDrawable;
    }
}
