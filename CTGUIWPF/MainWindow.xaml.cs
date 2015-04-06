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

namespace CTGUIWPF
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int currentView = 1;
        public MainWindow()
        {

            try
            {
                InitializeComponent();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        private void slide(Border oldVisual, Border newVisual)
        {
            oldVisual.Margin = new Thickness(300, 0, 0, 0);
            newVisual.Margin = new Thickness(0);
        }

        private void previousButton_Click(object sender, RoutedEventArgs e)
        {
            switch (currentView)
            {
                case 2:
                    slide(view2, view1);
                    currentView--;
                    break;
                case 3:
                    slide(view3, view2);
                    currentView--;
                    break;
            }
        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            switch (currentView)
            {
                case 1:
                    slide(view1, view2);
                    currentView++;
                    break;
                case 2:
                    slide(view2, view3);
                    currentView++;
                    break;
            }
        }
    }
}
