using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace gerenciador.escolar.Views
{
    public partial class TeacherListView : UserControl
    {
        public TeacherListView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
