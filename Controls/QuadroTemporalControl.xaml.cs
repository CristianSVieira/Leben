using Leben.Drawable;

namespace Leben.Controls;

public partial class QuadroTemporalControl : ContentView {
    private QuadroTemporalDrawable _QuadroTemporalDrawable; 

    public QuadroTemporalControl() {
        InitializeComponent();

        _QuadroTemporalDrawable = new QuadroTemporalDrawable(this);

        Inicializar();
    }

    public void Inicializar()
    {
        QuadroView.Drawable = _QuadroTemporalDrawable;
    }
}