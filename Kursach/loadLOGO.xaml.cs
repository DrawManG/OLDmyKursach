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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Kursach
{
    /// <summary>
    /// Логика взаимодействия для loadLOGO.xaml
    /// </summary>
    public partial class loadLOGO : Window
    {
        public loadLOGO()
        {
            InitializeComponent();
        }
        System.Windows.Threading.DispatcherTimer Ti = new System.Windows.Threading.DispatcherTimer();


        private void meme_Loaded(object sender, RoutedEventArgs e)
        {
            Storyboard sb = (Storyboard)FindResource("opcity");
            sb.Begin(bee);
            Storyboard sa = (Storyboard)FindResource("left_");
            sa.Completed += new EventHandler(comp);                                                                             //jdshkjasgdfkgaskfgkdasgfasdhflh
            sa.Begin(bee);
        }

        void comp(object sender, EventArgs e )
        {
            MainWindow mw = new MainWindow();
            mw.ShowDialog();
            this.Close();
            
        }

    }
}
