﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
                textBox1.Text = fbd.SelectedPath;
            }
            fbd.Dispose();
        }

        private void DoButton_Click(object sender, RoutedEventArgs e)
        {
            バックアップはできますWPF.ProgressBar progressBar = new バックアップはできますWPF.ProgressBar();
            progressBar.Owner = this;
            progressBar.Show();
        }
    }
}
