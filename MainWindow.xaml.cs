using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace murzaev_mvc
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            pattern.tbPerviy = tbOne;
            pattern.tbVtoroy = tbTwo;
            pattern.tbItogoviy = tbItogoviy;
            cbMoove.ItemsSource = pattern.operList;
        }

        private void buttRez_Click(object sender, RoutedEventArgs e)
        {
            pattern.One = Convert.ToInt32(tbOne.Text);
            pattern.Two = Convert.ToInt32(tbTwo.Text);
            pattern.cbMoove = cbMoove.SelectedIndex;
            tbItogoviy.Text = pattern.Rez;
        }
        
    }
}

