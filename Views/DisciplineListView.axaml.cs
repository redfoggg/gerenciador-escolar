using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace gerenciador.escolar.Views
{
    public partial class DisciplineListView : UserControl
    {
        public DisciplineListView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
