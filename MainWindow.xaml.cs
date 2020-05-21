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
using Intel8086;

namespace intel8086
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AssignValues();
        }

        private void executeButton_Click(object sender, RoutedEventArgs e)
        {
            switch (methods.SelectedOperation)
            {
                case 0:
                    methods.MOV();
                    break;
                case 1:
                    methods.SWAP();
                    break;
                case 2:
                    methods.ADD();
                    break;
                case 3:
                    methods.SUB();
                    break;
                default:
                    MessageBox.Show("Proszę wybrać operację");
                    break;
            }

            AssignValues();
        }

        private void listOperation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            methods.SelectedOperation = listOperation.SelectedIndex;
        }
        private void listFirstRegister_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            methods.SelectedFirstRegister = listFristRegister.SelectedIndex;
        }
        private void listSecondRegister_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            methods.SelectedSecondRegister = listSecondRegister.SelectedIndex;
        }

        private void AssignValues()
        {
            AX_TextBlock.Text = "AX #" + methods.AX.ToString("x");
            BX_TextBlock.Text = "BX #" + methods.BX.ToString("x");
            CX_TextBlock.Text = "CX #" + methods.CX.ToString("x");
            DX_TextBlock.Text = "DX #" + methods.DX.ToString("x");
        }
    }
}
