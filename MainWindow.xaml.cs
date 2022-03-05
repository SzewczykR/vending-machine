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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        VendingMachine vendingMachine = new VendingMachine();
        //DB db;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void cola_Click(object sender, RoutedEventArgs e)
        {
            vendingMachine.subtractCash(vendingMachine.getColaPrice());
        }

        private void fanta_Click(object sender, RoutedEventArgs e)
        {
            vendingMachine.subtractCash(vendingMachine.getFantaPrice());
        }

        private void sprite_Click(object sender, RoutedEventArgs e)
        {
            vendingMachine.subtractCash(vendingMachine.getSpritePrice());
        }

        private void monster_Click(object sender, RoutedEventArgs e)
        {
            vendingMachine.subtractCash(vendingMachine.getMonsterPrice());
        }

        private void lipton_Click(object sender, RoutedEventArgs e)
        {
            vendingMachine.subtractCash(vendingMachine.getLiptonPrice());
        }

        private void water_Click(object sender, RoutedEventArgs e)
        {
            vendingMachine.subtractCash(vendingMachine.getWaterPrice());
        }

        private void addCashToVendingMachine_Click(object sender, RoutedEventArgs e)
        {
            vendingMachine.addCash(5.0);
        }

        private void drinkOne_Click(object sender, RoutedEventArgs e)
        {
            //usun jeden losowy rekord z bazy
        }

        private void drinkAll_Click(object sender, RoutedEventArgs e)
        {
            //usun wszystkie rekordy z bazy
        }
    }
}
