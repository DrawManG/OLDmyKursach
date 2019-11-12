using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Kursach
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string sdwConnectionString = @"Data Source = 193.124.112.29,1433\SERVER; user id=Midas; password=1488228228q; Initial Catalog = PlayToPlay;";

        // Create a connection
        SqlConnection sdwDBConnection = new SqlConnection(sdwConnectionString);
        //timer panel menu otkrit and zakrit
        System.Windows.Threading.DispatcherTimer Times = new System.Windows.Threading.DispatcherTimer();
        System.Windows.Threading.DispatcherTimer qwe = new System.Windows.Threading.DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent(); //132
        }

        public void button4_Click(object sender, RoutedEventArgs e)
        {
            Storyboard sb = (Storyboard)FindResource("an");                                                                             //jdshkjasgdfkgaskfgkdasgfasdhflh
            sb.Begin(panel_menu);

            //Times.Tick += new EventHandler(Times_just);
            //Times.Interval = new TimeSpan(0, 0, 0);
            //Times.Start();
            //panel_menu.Opacity = 100;
            //panel_menu.Width = 1;


        }
        public void Times_just(object sender, EventArgs e)
        {
            panel_menu.Width += 1;
            if (panel_menu.Width >= 132)
            {
                Times.Stop();
                qwe.Stop();

            }


        }

        public void button3_Click(object sender, RoutedEventArgs e)
        {
            Storyboard sb = (Storyboard)FindResource("do");                                                                             //jdshkjasgdfkgaskfgkdasgfasdhflh
            sb.Begin(panel_menu);
            //qwe.Tick += new EventHandler(Times_just1);
            //qwe.Interval = new TimeSpan(0, 0, 0);
            //qwe.Start();
            //panel_menu.Width -= 1;
            //if (panel_menu.Width <= 1)
            //{
            //    qwe.Stop();
            //    Times.Stop();
            //}
        }
        private void Times_just1(object sender, EventArgs e)
        {
            if (panel_menu.Width >= 1)
                panel_menu.Width -= 1;



        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            Storyboard sb = (Storyboard)FindResource("do");                                                                             //jdshkjasgdfkgaskfgkdasgfasdhflh
            sb.Begin(panel_menu);

            sett.Visibility = Visibility.Hidden;
            registr.Visibility = Visibility.Hidden;

            aftor.Visibility = Visibility.Visible;

            qwe.Start();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Storyboard sb = (Storyboard)FindResource("do");                                                                             //jdshkjasgdfkgaskfgkdasgfasdhflh
            sb.Begin(panel_menu);
            sett.Visibility = Visibility.Hidden;
            aftor.Visibility = Visibility.Hidden;


            registr.Visibility = Visibility.Visible;
        }


        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void sett_Loaded(object sender, RoutedEventArgs e)
        {
            comboBox1.Items.Add("Russian");
            comboBox1.Items.Add("English");
            comboBox.Items.Add("Default");
            comboBox.Items.Add("Colorless");
            comboBox.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {

            Storyboard sb = (Storyboard)FindResource("do");                                                                             //jdshkjasgdfkgaskfgkdasgfasdhflh
            sb.Begin(panel_menu);
            sett.Visibility = Visibility.Visible;
            aftor.Visibility = Visibility.Hidden;
            registr.Visibility = Visibility.Hidden;
        }

        public void Window_Loaded(object sender, RoutedEventArgs e)
        {



            mm.Visibility = Visibility.Hidden;
            prodaja.Visibility = Visibility.Hidden;
            menu_funcional.Visibility = Visibility.Hidden;
            postavshic.Visibility = Visibility.Hidden;
            aftor.Opacity = 100;
            registr.Opacity = 100;
            try
            {


                sdwDBConnection.Open();

                Okno.Title = "Launcher" + "  " + "(Подключен к БД)";

                button8.Visibility = Visibility.Hidden;


            }
            catch
            {
                Okno.Title = "Launcher" + "  " + "(Ошибка подключения к БД)";
                button4.Visibility = Visibility.Hidden;
                button8.Visibility = Visibility.Visible;

            }



        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (comboBox.Text == "Colorless")
            {
                panel_menu.Background = Brushes.Black;
                aftor.Background = Brushes.Black;
                registr.Background = Brushes.Black;
                sett.Background = Brushes.Black;
                label.Background = Brushes.White;
                label1.Background = Brushes.White;
                label2.Background = Brushes.White;
                label3.Background = Brushes.White;
                label4.Background = Brushes.White;
                label5.Background = Brushes.White;
                label6.Background = Brushes.White;
                label7.Background = Brushes.White;
                label8.Background = Brushes.White;
                label9.Background = Brushes.White;
                //label10.Background = Brushes.White;
                label11.Background = Brushes.White;
                label12.Background = Brushes.White;
                label13.Background = Brushes.White;
                button4.Background = Brushes.White;
                button5.Background = Brushes.White;

            }
            if (comboBox.Text == "Default")
            {
                panel_menu.Background = Brushes.White;
                aftor.Background = Brushes.GreenYellow;
                registr.Background = Brushes.Plum;
                sett.Background = Brushes.LightPink;
                label.Background = Brushes.GreenYellow;
                label1.Background = Brushes.GreenYellow;
                label2.Background = Brushes.GreenYellow;
                label3.Background = Brushes.GreenYellow;
                label4.Background = Brushes.Plum;
                label5.Background = Brushes.Plum;
                label6.Background = Brushes.Plum;
                label7.Background = Brushes.Plum;
                label8.Background = Brushes.Plum;
                label9.Background = Brushes.LightPink;
                //label10.Background = Brushes.LightPink;
                label11.Background = Brushes.LightPink;
                label12.Background = Brushes.LightPink;
                label13.Background = Brushes.LightPink;
                button4.Background = Brushes.Aqua;
                button5.Background = Brushes.Aqua;
            }
            if (comboBox1.Text == "English")
            {
                button.Content = "Authorization";
                button1.Content = "Check in";
                button2.Content = "Setting";
                label.Content = "Authorization";
                label1.Content = "Login";
                label2.Content = "Password";
                label3.Content = "";
                label4.Content = "Check in";
                label5.Content = "Login";
                label6.Content = "Password";
                label7.Content = "Repeat the password";
                label8.Content = "";
                label9.Content = "Setting";
                //label10.Content = "Transparent";
                label11.Content = "Theme";
                label12.Content = "Language";
                label13.Content = "";
                button5.Content = "Connect";
                button6.Content = "Sign up now";
                button7.Content = "Apply settings";

            }
            if (comboBox1.Text == "Russian")
            {
                button.Content = "Авторизация";
                button1.Content = "Регистрация";
                button2.Content = "Настройки";
                label.Content = "Авторизация";
                label1.Content = "Логин";
                label2.Content = "Пароль";
                label3.Content = "";
                label4.Content = "Регистрация";
                label5.Content = "Логин";
                label6.Content = "Пароль";
                label7.Content = "Повторите пароль";
                label8.Content = "";
                label9.Content = "Настройки";
                //label10.Content = "Прозрачность";
                label11.Content = "Тема";
                label12.Content = "Язык";
                label13.Content = "";
                button5.Content = "Подключится";
                button6.Content = "Зарегистрироваться";
                button7.Content = "Приминить настройки";

            }
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                button4.Visibility = Visibility.Visible;
                // Create a String to hold the database connection string.
                // NOTE: Put in a real database connection string here or runtime won't work
                string sdwConnectionString = @"Data Source = 193.124.112.29,1433\SERVER; user id=Midas; password=1488228228q; Initial Catalog = PlayToPlay;";

                // Create a connection
                SqlConnection sdwDBConnection = new SqlConnection(sdwConnectionString);

                // Open the connection
                sdwDBConnection.Open();




                Okno.Title = "Launcher" + "  " + "(Подключен к БД)";
                //dataGrid1.ItemsSource = dt.DefaultView;
                button8.Visibility = Visibility.Hidden;
            }
            catch
            {
                Okno.Title = "Launcher" + "  " + "(Ошибка подключения к БД)";
                button4.Visibility = Visibility.Hidden;
                button8.Visibility = Visibility.Visible;
                //reconn.Visibility = Visibility.Visible;
                // reconnlab.Content = "У вас проблемы с интренетом,"+ "\n" + " попроюуйте повторно подключится к интернету или устраните  неполадки";
            }
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {

            using (SqlConnection sc = new SqlConnection(sdwConnectionString))
            {

                sc.Open();

                SqlCommand sqlcmd = new SqlCommand("SELECT  Password FROM Client_Avtorizat WHERE Login = '" + textBox.Text +  "' ", sc);

                Object passO = sqlcmd.ExecuteScalar();

                if (passO == null)
                {
                    MessageBox.Show("Такого пользователя не существует");
                    return;
                }

                if (passO.ToString() != textBox1.Text)
                {
                    MessageBox.Show("Не правильный пароль");
                    return;
                }

                MessageBox.Show("Вы успешно залогинены");

                registr.Visibility = Visibility.Hidden;
                aftor.Visibility = Visibility.Hidden;
                sett.Visibility = Visibility.Hidden;
                panel_menu.Visibility = Visibility.Hidden;
                button4.Visibility = Visibility.Hidden;
                Okno.WindowStyle = WindowStyle.None;
                Okno.WindowState = WindowState.Maximized;
                Okno.BorderBrush = new SolidColorBrush(SystemColors.ControlColor);
                //Okno.BorderBrush = new SolidColorBrush(SystemColors.ControlBrush);
                Okno.Background = new SolidColorBrush(Color.FromArgb(90, 0xF0, 0x00, 0xFF));
                menu_funcional.Visibility = Visibility.Visible;
                menu_funcional.Opacity = 100;

            }

            }



        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public void button9_Click(object sender, RoutedEventArgs e)
        {
            prodaja.Visibility = Visibility.Hidden;
            mm.Visibility = Visibility.Visible;
            postavshic.Visibility = Visibility.Hidden;
            using (SqlConnection sc = new SqlConnection(sdwConnectionString))
            {
                sc.Open();
                string sql = "SELECT *FROM db_owner.Sklad";
                SqlCommand com = new SqlCommand(sql, sc);

                using (SqlDataAdapter adapter = new SqlDataAdapter(com))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    sklad.ItemsSource = dt.DefaultView;
                    mm.Opacity = 100;
                }

            }
        }


        private void button10_Click(object sender, RoutedEventArgs e)
        {
            mm.Visibility = Visibility.Hidden;
            prodaja.Visibility = Visibility.Visible;
            postavshic.Visibility = Visibility.Hidden;


        }

        private void button12_Click_1(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void textBox11_MouseMove(object sender, MouseEventArgs e)
        {
            if (textBox11.Text == "поиск")
            {
                textBox11.Text = null;
            }


        }

        private void button13_Click(object sender, RoutedEventArgs e)
        {
            //POICK//


        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
            mm.Visibility = Visibility.Hidden;
            prodaja.Visibility = Visibility.Hidden;
            postavshic.Visibility = Visibility.Visible;
            using (SqlConnection sc = new SqlConnection(sdwConnectionString))
            {
                sc.Open();
                string sql = "SELECT *FROM db_owner.Postavshik";
                SqlCommand com = new SqlCommand(sql, sc);

                using (SqlDataAdapter adapter = new SqlDataAdapter(com))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGrid.ItemsSource = dt.DefaultView;

                }


            }
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection sc = new SqlConnection(sdwConnectionString))
            {

                sc.Open();

                SqlCommand sqlcmd = new SqlCommand("usp_Client_AvtorizatInsert", sc);
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.Parameters.AddWithValue("@Login", textBox2.Text);
                sqlcmd.Parameters.AddWithValue("@Password", textBox3.Text);
                sqlcmd.Parameters.AddWithValue("@Mail", "");
                sqlcmd.Parameters.AddWithValue("@Fam", "");
                sqlcmd.Parameters.AddWithValue("@Imya", "");
                sqlcmd.Parameters.AddWithValue("@Othc", "");
                sqlcmd.Parameters.AddWithValue("@Data_rojd", "");

                sqlcmd.ExecuteNonQuery();
            }
        }

        private void button16_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.Save
        }
    }
}       
    



