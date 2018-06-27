using System;
using System.Windows;

namespace バックアップはできますWPF
{
    /// <summary>
    /// ResultForm.xaml の相互作用ロジック
    /// </summary>
    public partial class ResultForm : Window
    {
        public ResultForm()
        {
            InitializeComponent();
        }

        private void ResultForm1_Closed(object sender, EventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
