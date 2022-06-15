using System.Windows;
using DevExpress.Xpf.Layout.Core;

namespace DockPanelInCode_Ex {
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
        }
        #region #1
        private void Button1_Click(object sender, RoutedEventArgs e) {
            // Dock the Properties panel at the bottom of the Output panel.
            dockManager1.DockController.Dock(paneProperties, paneOutput, DockType.Bottom);
        }
        private void Button2_Click(object sender, RoutedEventArgs e) {
            // Dock the Properties panel to the Output panel, creating a tab container.
            dockManager1.DockController.Dock(paneProperties, paneOutput, DockType.Fill);
        }
        #endregion #1
    }
}
