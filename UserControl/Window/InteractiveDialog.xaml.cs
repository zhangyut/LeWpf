using LeWpf.ViewModel;
using System.Windows;

namespace LeWpf.UserControl.Window
{
    /// <summary>
    /// InteractiveDialog.xaml 的交互逻辑
    /// </summary>
    public partial class InteractiveDialog
    {
        private InteractiveDialogViewModel vm;
        public InteractiveDialog(string info = "Title")
        {
            InitializeComponent();

            vm = new InteractiveDialogViewModel
            {
                Title = info,
            };

            DataContext = vm;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Dialog.vm.Content = vm.Content;
        }
    }
}
