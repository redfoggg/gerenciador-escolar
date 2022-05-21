using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace gerenciador.escolar.Views
{
    public partial class StudentListView : UserControl
    {
        public StudentListView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
