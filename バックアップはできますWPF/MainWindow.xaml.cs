using System;
using System.Windows;
using System.Windows.Forms;

namespace バックアップはできますWPF
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //FolderBrowserDialogクラスのインスタンスを作成
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            //上部に表示する説明テキストを指定する
            fbd.Description = "フォルダを指定してください。";
            //ルートフォルダを指定する
            fbd.RootFolder = Environment.SpecialFolder.MyComputer;
            //最初に選択するフォルダを指定する
            //RootFolder以下にあるフォルダである必要がある
            fbd.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            //ユーザーが新しいフォルダを作成できるようにする
            //デフォルトでTrue
            fbd.ShowNewFolderButton = false;

            //ダイアログを表示する
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //選択されたフォルダを表示する
                PathTextBox.Text = fbd.SelectedPath;
            }
            fbd.Dispose();
        }

        private void DoButton_Click(object sender, RoutedEventArgs e)
        {
            PathTextBox.Text = PathTextBox.Text.Trim();
            if (string.IsNullOrEmpty(PathTextBox.Text))
            {
                System.Windows.MessageBox.Show("場所が不正です", "エラー", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            this.Hide();
            ResultForm resultForm = new ResultForm();
            resultForm.Owner = this;
            resultForm.Show();
            ProgressBar progressBar = new ProgressBar(this, resultForm);
            progressBar.Owner = this;
            progressBar.ShowDialog();

        }
    }
}
